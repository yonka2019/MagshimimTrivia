#pragma once

#include <string>
#include "sqlite3.h"
#include "IDatabase.h"
#include <io.h>
#include <list>

#define DB_NAME "TriviaDB.db"

#define USERNAME "USERNAME"
#define PASSWORD "PASSWORD"

#define QUESTION "QUESTION"
#define C_ANSWER1 "C_ANSWER1"
#define W_ANSWER "W_ANSWER"

#define AVG_TIME "AVG_TIME"


using std::string;

class SqliteDataBase : public IDatabase
{
public:
	static SqliteDataBase& getInstance()
	{
		static SqliteDataBase instance;
		return instance;
	}
	// delete copy constructor and assignment operator for singleton
	SqliteDataBase(SqliteDataBase const&) = delete;
	void operator=(SqliteDataBase const&) = delete;

	~SqliteDataBase();

	/// <summary>
	/// The function checks if the given user exists in the database
	/// </summary>
	/// <param name="username">True if exists, false if not</param>
	/// <returns></returns>
	bool doesUserExist(const string username) override;

	/// <summary>
	/// The fucntion checks if the given password matches the given username's password in the database
	/// </summary>
	/// <param name="username">Username to check</param>
	/// <param name="password">Password to check</param>
	/// <returns>True if matches, false if not</returns>
	bool doesPasswordMatch(const string username, const string password) override;

	/// <summary>
	/// The funcion adds a new user to the database with the given info
	/// </summary>
	/// <param name="username">Username of new user</param>
	/// <param name="password">Password of new user</param>
	/// <param name="email">email of new user</param>
	/// <param name="address">address of new user</param>
	/// <param name="phoneNumber">phone number of new user</param>
	/// <param name="birthDate">birth date of new user</param>
	void addNewUser(const string username, const string password, const string email,
		const string address, const string phoneNumber, const string birthDate) override;

	/// <summary>
	/// The fucntion gets the questions from the database (with given amount) 
	/// </summary>
	/// <param name="questionsNumber">Amount of questions to get</param>
	/// <returns>List of the questions</returns>
	std::list<Question> getQuestions(const int questionsNumber) override;
	
	/// <summary>
	/// The function gives the amount of questions in the databse
	/// </summary>
	/// <returns>Amount of questions</returns>
	int getAmountOfQuestions() override;

	/// <summary>
	/// The function gives the average answer time of given player
	/// </summary>
	/// <param name="username">Name of user to get the info on</param>
	/// <returns>Average answer time</returns>
	float getPlayerAverageAnswerTime(const string username) override;

	/// <summary>
	/// The function gives the amount of correct answer a given player has
	/// </summary>
	/// <param name="username">Name of user to get the info on</param>
	/// <returns>Amount of correct answers</returns>
	int getNumOfCorrectAnswers(const string username) override;

	int getNumOfWrongAnswers(const string username) override;

	/// <summary>
	/// The function gives the total amount of answers a given player has
	/// </summary>
	/// <param name="username">Name of user to get the info on</param>
	/// <returns>Total amount of answers</returns>
	int getNumOfTotalAnswers(const string username) override;

	/// <summary>
	/// The function gives the amount of games a given player played
	/// </summary>
	/// <param name="username">Name of user to get the info on</param>
	/// <returns>Amount of games a player played</returns>
	int getNumOfPlayerGames(const string username) override;

	/// <summary>
	/// The function sets the given player's average answer time to a new given value
	/// </summary>
	/// <param name="username">Name of user to change</param>
	/// <param name="new_avg_time">New average time</param>
	void setPlayerAverageAnswerTime(const std::string username, const float new_avg_time) override;

	/// <summary>
	/// The function sets the given player's correct answers count to a new given value
	/// </summary>
	/// <param name="username">Name of user to change</param>
	/// <param name="new_correct_answers">New correct answer count</param>
	void setNumOfCorrectAnswers(const std::string username, const int new_correct_answers) override;

	/// <summary>
	/// The function sets the given player's wrong answers count to a new given value
	/// </summary>
	/// <param name="username">Name of user to change</param>
	/// <param name="new_wrong_answers">New wrong answer count</param>
	void setNumOfWrongAnswers(const std::string username, const int new_wrong_answers) override;

	/// <summary>
	/// The function sets the given player's games count to a new given value
	/// </summary>
	/// <param name="username">Name of user to change</param>
	/// <param name="new_num_games">New games count</param>
	void setNumOfPlayerGames(const std::string username, const int new_num_games) override;

	/// <summary>
	/// The function gives all the users in the database
	/// </summary>
	/// <returns>List of all the users in the database</returns>
	std::list<string> getUsers() override;

	/// <summary>
	/// The fucntion adds the given function to the db
	/// </summary>
	/// <param name="question">The question</param>
	/// <param name="c_answer1">Correct answer</param>
	/// <param name="w_answer2">First wrong answer</param>
	/// <param name="w_answer3">Second wrong answer</param>
	/// <param name="w_answer4">Third wrong answer</param>
	void addQuestion(const string question, const string c_answer1, const string w_answer2, const string w_answer3, const string w_answer4) override;

private:
	SqliteDataBase();
	/// <summary>
	/// Sqlite(3) local database pointer
	/// </summary>
	sqlite3* _db;

	/// <summary>
	/// Runs query according the parameters (callback/default)
	/// </summary>
	/// <param name="query">query string, which sent into the database</param>
	/// <param name="callback">callback function (optional)</param>
	/// <param name="data">return pointer variable which will contains the required data(optional)</param>
	/// <returns>true if success, either, false</returns>
	bool runQuery(const string query, int (*callback)(void*, int, char**, char**) = nullptr, void* data = nullptr);
};