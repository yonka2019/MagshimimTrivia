#pragma once

#include <iostream>
#include <string>
#include <vector>
#include <map>
#include "LoggedUser.h"
#include "Question.h"
#include <time.h>
#include <mutex>

#define FINISHED_GAME "finished game"

using std::vector;
using std::map;
using std::string;
using std::multimap;
using std::mutex;

class GameData
{
public:
	GameData(const Question currentQuestion, const unsigned int correctAnswerCount, const unsigned int wrongAnswerCount, const double averageAnswerTime)
	{
		this->currentQuestion = currentQuestion;
		this->correctAnswerCount = correctAnswerCount;
		this->wrongAnswerCount = wrongAnswerCount;
		this->averageAnswerTime = averageAnswerTime;
	}

	Question currentQuestion;
	unsigned int correctAnswerCount;
	unsigned int wrongAnswerCount;
	double averageAnswerTime;
};

class Game
{
public:
	mutable int usersInGame;
	Game(const vector<Question> questions, const vector<LoggedUser> users, const int gameId);
	Game(const Game& game);
	void operator=(const Game& game);
	~Game() = default;

	/// <summary>
	/// The function gets a question for the user
	/// </summary>
	/// <param name="user">User to get his question</param>
	/// <returns>Current question for the user</returns>
	Question getQuestionForUser(const LoggedUser user) const;

	/// <summary>
	/// The function submits the given answer
	/// </summary>
	/// <param name="user">User to remove</param>
	/// <param name="answer">Answer to submit</param>
	void submitAnswer(const LoggedUser user, const unsigned int answer);

	/// <summary>
	/// The function removes the user
	/// </summary>
	/// <param name="user">User to remove</param>
	void removePlayer(const LoggedUser user);

	/// <summary>
	/// The function gives the game's id
	/// </summary>
	/// <returns>Game's id</returns>
	int getGameId() const;

	/// <summary>
	/// The function gives the game's players
	/// </summary>
	/// <returns>Game's players</returns>
	multimap<LoggedUser, GameData>& getPlayers() const;

	/// <summary>
	/// The function checks if all the players finished the game
	/// </summary>
	/// <returns>True if all finished. False if not</returns>
	bool allFinishedGame() const;

	vector<GameData*>& getGameDatas();

private:
	vector<Question> m_questions;
	mutable multimap<LoggedUser, GameData> m_players;
	int game_id;
	mutable mutex players_mtx;
	vector<GameData*> game_datas;
};