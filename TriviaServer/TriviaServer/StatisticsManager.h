#pragma once

#include <iostream>
#include <vector>
#include <string>
#include "sqlite3.h"
#include "IDatabase.h"
#include "SqliteDataBase.h"
#include "Responses.h"
#include <map>

using std::vector;
using std::string;

#define AMOUNT_OF_PLAYERS_TO_SHOW 3
#define POINTS_FOR_CORRECT 10
#define POINTS_FOR_WRONG 2
#define C_ANSWER_INDEX 0
#define W_ANSWER_INDEX 1
#define AVG_TIME_INDEX 2

class StatisticsManager
{
public:

	StatisticsManager(IDatabase* db);
	/// <summary>
	/// The function returns vector which sorted by the highest points
	/// </summary>
	/// <returns>vector which sorted by the highest points</returns>
	vector<Highscore> getHighScore() const;

	/// <summary>
	/// The function gets user statistics (wrong answers, correct answers, avg time)
	/// </summary>
	/// <param name="username">username to get his data</param>
	/// <returns>data packaged into vector of strings [0] - Correct answers | [1] - Wrong answers | [2] - Average time</returns>
	vector<string> getUserStatistics(const string username) const;

	/// <summary>
	/// The function counts the points of the username according his statistics (correct answers, wrong answers and avg time)
	/// </summary>
	/// <param name="usernameStatistics">username statistics</param>
	/// <returns>counted points of the user</returns>
	static double countPoints(const vector<string> usernameStatistics);

private:
	

	IDatabase* m_database;
};