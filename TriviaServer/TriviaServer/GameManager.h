#pragma once
#include "Game.h"
#include "IDatabase.h"
#include "Room.h"
#include <map>
#include <time.h>
#include <mutex>

using std::list;
using std::mutex;

class GameManager
{
public:
	GameManager(IDatabase* db);
	~GameManager() = default;

	/// <summary>
	/// The function creates a new game
	/// </summary>
	/// <param name="room">Room of the game</param>
	Game& createGame(const Room& room);

	/// <summary>
	/// The function deletes the game
	/// </summary>
	void deleteGame(const Game& game);

	/// <summary>
	/// The function returns the game with the given id 
	/// </summary>
	/// <param name="ID">Id of game to get</param>
	/// <returns>Game with the given id</returns>
	Game& getGame(const int ID) const;
	

private:
	IDatabase* m_database;
	vector<Game*> m_games;
	mutable mutex games_mtx;
};