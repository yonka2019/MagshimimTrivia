#include "GameManager.h"

GameManager::GameManager(IDatabase* db)
{
    this->m_database = db;
}


Game& GameManager::createGame(const Room& room)
{
	list<Question> questions = this->m_database->getQuestions(room.getMetaData().numOfQuestionsInGame);

	vector<Question> questions_formatted{ std::begin(questions), std::end(questions) };

	vector<LoggedUser> players = room.getAllLoggedUsers();

	Game* new_game = new Game(questions_formatted, players, room.getMetaData().id); // create new game with the players, questions and id

	for (auto& player : new_game->getPlayers())
	{
		player.second.averageAnswerTime = (double)time(NULL); 
	}

	this->games_mtx.lock();
	this->m_games.push_back(new_game);
	this->games_mtx.unlock();

	return (*new_game);
}


void GameManager::deleteGame(const Game& game)
{
	this->games_mtx.lock();
	for (vector<Game*>::iterator curr_game = m_games.begin(); curr_game != m_games.end(); curr_game++)
	{
		if ((*curr_game)->getGameId() == game.getGameId())
		{
			for (auto* game_data : (*curr_game)->getGameDatas()) // delete the game datas
			{
				delete game_data;
			}

			//delete the game
			delete *curr_game;
			this->m_games.erase(curr_game);
			this->games_mtx.unlock();
			return;
		}
	}

	this->games_mtx.unlock();
}


Game& GameManager::getGame(const int ID) const
{
	this->games_mtx.lock();
	for (Game* game : this->m_games)
	{
		if (game->getGameId() == ID) // get game by id
		{
			this->games_mtx.unlock();
			return *game;
		}
	}

	this->games_mtx.unlock();
}

