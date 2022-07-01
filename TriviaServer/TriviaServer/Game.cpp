#include "Game.h"

Game::Game(const vector<Question> questions, const vector<LoggedUser> users, const int gameId)
{
	for (auto& question : questions)
	{
		this->m_questions.push_back(question);
	}

	this->players_mtx.lock();
	for (LoggedUser user : users)
	{
		GameData g = GameData(this->m_questions[0], 0, 0, 0 ); // set to first details
		this->m_players.insert({ user, g });
	}
	this->players_mtx.unlock();

	this->game_id = gameId;
	this->usersInGame = 0;
}

Game::Game(const Game& game)
{
	this->m_questions = game.m_questions;
	this->m_players = game.m_players;
	this->game_id = game.game_id;
}

void Game::operator=(const Game& game)
{
	*this = Game(game);
}


Question Game::getQuestionForUser(const LoggedUser user) const
{
	this->players_mtx.lock();
	
	for (auto& player : this->m_players)
	{
		if (player.first.getUsername() == user.getUsername())
		{
			this->players_mtx.unlock();
			return player.second.currentQuestion;
		}
	}

	this->players_mtx.unlock();
	return Question("", "", vector<string>());
}


void Game::submitAnswer(const LoggedUser user, const unsigned int answer)
{
	this->players_mtx.lock();

	GameData* game_data = NULL;

	this->game_datas.push_back(game_data);

	for (auto& player : this->m_players) // search for player
	{
		if (player.first.getUsername() == user.getUsername())
		{
			game_data = &player.second;
		}
	}

	
	if (game_data != NULL) // exists
	{
		if (answer == 0)
		{
			game_data->correctAnswerCount++;
		}

		else
		{
			game_data->wrongAnswerCount++;
		}

		int i = 0;
		for (i = 0; i < this->m_questions.size(); i++) // search for question index
		{
			if (this->m_questions[i].getQuestion() == game_data->currentQuestion.getQuestion())
			{
				break;
			}
		}

		if (game_data->currentQuestion.getQuestion() != FINISHED_GAME) // check if the questions are over
		{
			if (i + 1 != this->m_questions.size()) // check if the question is the last one
				game_data->currentQuestion = this->m_questions[i + 1];


			else
			{
				game_data->currentQuestion = Question(FINISHED_GAME, "", vector<string>()); // set questions to be over

				game_data->averageAnswerTime = (double)time(NULL) - game_data->averageAnswerTime;
				game_data->averageAnswerTime /= (game_data->correctAnswerCount + game_data->wrongAnswerCount); // set avg time
			
			}
		}
	}

	this->players_mtx.unlock();

}


void Game::removePlayer(const LoggedUser user)
{
	this->players_mtx.lock();

	map<LoggedUser, GameData>::iterator player = this->m_players.find(user);

	if (player != this->m_players.end())
	{
		this->m_players.erase(user);
	}
	this->players_mtx.unlock();

}


int Game::getGameId() const
{
	return this->game_id;
}


multimap<LoggedUser, GameData>& Game::getPlayers() const
{
	return this->m_players;
}


bool Game::allFinishedGame() const
{
	this->players_mtx.lock();
	
	for (auto& player : this->m_players) // check if for all players, the questions are over
	{
		if (player.second.currentQuestion.getQuestion() != FINISHED_GAME)
		{
			this->players_mtx.unlock();
			return false;
		}
	}

	this->players_mtx.unlock();
	return true;
}

vector<GameData*>& Game::getGameDatas()
{
	return this->game_datas;
}
