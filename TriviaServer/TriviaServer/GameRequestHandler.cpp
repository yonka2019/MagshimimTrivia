#include "GameRequestHandler.h"


GameRequestHandler::GameRequestHandler(const string username, const SOCKET socket, GameManager& gameManager, RequestHandlerFactory& factory, Game& game) : m_user(username, socket), m_gameManager(gameManager), m_handlerFactory(factory), m_game(game)
{
}


bool GameRequestHandler::isRequestRelevant(const RequestInfo request) const
{
	return (request.id == LEAVE_GAME_REQUEST) ||
		(request.id == GET_QUESTION_REQUEST) ||
		(request.id == SUBMIT_ANSWER_REQUEST) ||
		(request.id == GET_GAME_RESULT_REQUEST) ||
		(request.id == GET_ROOM_STATE_REQUEST); // check if request is relevant to Game
}


RequestResult GameRequestHandler::handleRequest(const RequestInfo request, const SOCKET socket) const
{
	try
	{
		if (request.id == LEAVE_GAME_REQUEST) // leave game
		{
			return this->leaveGame(request);
		}

		else if (request.id == GET_QUESTION_REQUEST) // get question
		{
			return this->getQuestion(request);
		}

		else if (request.id == SUBMIT_ANSWER_REQUEST) // submit answer
		{
			return this->submitAnswer(request);
		}

		else if (request.id == GET_GAME_RESULT_REQUEST) // get game results
		{
			return this->getGameResults(request);
		}


		// in case the client sent a get room state request before the handlers were changed - we send an empty message
		else if (request.id == GET_ROOM_STATE_REQUEST)
		{
			return { vector<char>(), this->m_handlerFactory.createGameRequestHandler(this->m_user.getUsername(), this->m_user.getSocket(), this->m_gameManager.getGame(this->m_game.getGameId())) };
		}

	}

	catch (nlohmann::json::exception& e) // json error
	{
		ErrorResponse res = { "[ERROR] Request contains invalid json" };
		return { JsonResponsePacketSerializer::serializeResponse(res), nullptr };
	}

	catch (std::exception& e) // different error
	{
		ErrorResponse res = { e.what() };
		return { JsonResponsePacketSerializer::serializeResponse(res), nullptr };
	}
}


RequestResult GameRequestHandler::getQuestion(const RequestInfo request) const
{
	Game& game = this->m_gameManager.getGame(this->m_game.getGameId());
	Question curr_question = game.getQuestionForUser(this->m_user);

	map<unsigned int, string> answers;
	unsigned int curr_index = 0;

	unsigned int status = SUCCESS_RESPONSE;

	if (curr_question.getQuestion() == "")
	{
		status = FAIL_RESPONSE;
	}

	for (string answer : curr_question.getPossibleAnswers())
	{
		answers[curr_index] = answer;
		curr_index++;
	}

	GetQuestionResponse res = { status, curr_question.getQuestion(), answers };
	return { JsonResponsePacketSerializer::serializeResponse(res), (IRequestHandler*)this->m_handlerFactory.createGameRequestHandler(this->m_user.getUsername(), this->m_user.getSocket(), this->m_gameManager.getGame(this->m_game.getGameId())) };

}


RequestResult GameRequestHandler::submitAnswer(const RequestInfo request) const
{
	SubmitAnswerRequest req = JsonRequestPacketDeserializer::deserializerSubmitAnswerRequest(request.buffer);

	this->m_gameManager.getGame(this->m_game.getGameId()).submitAnswer(this->m_user, req.answerId);

	SubmitAnswerResponse res = { SUCCESS_RESPONSE, 0 };

	return { JsonResponsePacketSerializer::serializeResponse(res), (IRequestHandler*)this->m_handlerFactory.createGameRequestHandler(this->m_user.getUsername(), this->m_user.getSocket(), this->m_gameManager.getGame(this->m_game.getGameId())) };

}


RequestResult GameRequestHandler::getGameResults(const RequestInfo request) const
{
	multimap<LoggedUser, GameData> players = this->m_game.getPlayers();
	vector<PlayerResults> all_results;
	unsigned int status = FAIL_RESPONSE;

	IRequestHandler* handler = nullptr;

	if (this->m_game.allFinishedGame()) // all players finished game
	{
		for (auto& player : players)
		{
			vector<string> player_info;
			string name = player.first.getUsername();

			this->saveResultsInDb(player); // save the game results in the database

			player_info.push_back(std::to_string(player.second.correctAnswerCount));
			player_info.push_back(std::to_string(player.second.wrongAnswerCount));
			player_info.push_back(std::to_string(player.second.averageAnswerTime));

			all_results.push_back({ player.first.getUsername(), player.second.correctAnswerCount, player.second.wrongAnswerCount, player.second.averageAnswerTime, StatisticsManager::countPoints(player_info) });
		}

		status = SUCCESS_RESPONSE;
		handler = (IRequestHandler*)this->m_handlerFactory.createMenuRequestHandler(this->m_user.getUsername(), this->m_user.getSocket());

		this->mutexUsersCounter.lock();
		this->m_game.usersInGame++;

		if (this->m_game.usersInGame == this->m_game.getPlayers().size()) // everyone finished
		{
			this->m_handlerFactory.getRoomManager().deleteRoom(this->m_game.getGameId()); // remove room
			this->m_gameManager.deleteGame(this->m_gameManager.getGame(this->m_game.getGameId())); // remove game
		}

		this->mutexUsersCounter.unlock();
	}
	else
		handler = (IRequestHandler*)this->m_handlerFactory.createGameRequestHandler(this->m_user.getUsername(), this->m_user.getSocket(), this->m_gameManager.getGame(this->m_game.getGameId()));

	GetGameResultsResponse res = { status,  all_results };

	return { JsonResponsePacketSerializer::serializeResponse(res), handler };

}


RequestResult GameRequestHandler::leaveGame(const RequestInfo request) const
{
	for (auto& player : this->m_gameManager.getGame(this->m_game.getGameId()).getPlayers()) // search for user
	{
		if (player.first.getUsername() == this->m_user.getUsername())
		{
			player.second.currentQuestion = Question(FINISHED_GAME, "", vector<string>());
			player.second.averageAnswerTime = (double)time(NULL) - player.second.averageAnswerTime;
			player.second.averageAnswerTime /= (player.second.correctAnswerCount + player.second.wrongAnswerCount); // set avg time

			this->saveResultsInDb(player); // save in db
		}
	}

	this->m_game.usersInGame++;

	if (this->m_game.usersInGame == this->m_game.getPlayers().size()) // everyone finished
	{
		this->m_handlerFactory.getRoomManager().deleteRoom(this->m_game.getGameId()); // remove room
		this->m_gameManager.deleteGame(this->m_gameManager.getGame(this->m_game.getGameId())); // remove game
	}

	LeaveGameResponse res = { SUCCESS_RESPONSE };

	return { JsonResponsePacketSerializer::serializeResponse(res), (IRequestHandler*)this->m_handlerFactory.createMenuRequestHandler(this->m_user.getUsername(), this->m_user.getSocket()) };
}

void GameRequestHandler::saveResultsInDb(const std::pair<LoggedUser, const GameData> player) const
{
	string name = player.first.getUsername();
	//get current data from db
	int new_c_answers = this->m_handlerFactory.getDataBase()->getNumOfCorrectAnswers(name);
	int new_w_answers = this->m_handlerFactory.getDataBase()->getNumOfWrongAnswers(name);
	int new_num_games = this->m_handlerFactory.getDataBase()->getNumOfPlayerGames(name);
	float new_avg_time = this->m_handlerFactory.getDataBase()->getPlayerAverageAnswerTime(name);

	//update data
	new_c_answers += player.second.correctAnswerCount;
	new_w_answers += player.second.wrongAnswerCount;
	new_num_games++;

	if (new_avg_time == 0) // first game
		new_avg_time = player.second.averageAnswerTime;

	else // not the first game
		new_avg_time = ((new_avg_time + player.second.averageAnswerTime) / 2);

	//insert updated data to db
	this->m_handlerFactory.getDataBase()->setNumOfCorrectAnswers(name, new_c_answers);
	this->m_handlerFactory.getDataBase()->setNumOfWrongAnswers(name, new_w_answers);
	this->m_handlerFactory.getDataBase()->setNumOfPlayerGames(name, new_num_games);
	this->m_handlerFactory.getDataBase()->setPlayerAverageAnswerTime(name, new_avg_time);
}
