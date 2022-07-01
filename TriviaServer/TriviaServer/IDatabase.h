#pragma once
#include <iostream>
#include <string>
#include <list>
#include "Question.h"


class IDatabase
{
public:
	/// <summary>
	/// The function checks if username exist in the database
	/// </summary>
	/// <param name="username">username string to check if he exist</param>
	/// <returns>true if username exists, else, false</returns>
	virtual bool doesUserExist(const std::string username) = 0;

	/// <summary>
	/// The function checks if the given password matches according the username which the database contains
	/// </summary>
	/// <param name="username">username which password we want to check</param>
	/// <param name="password">password which we want to compare with the username password</param>
	/// <returns>true if the passswords equals.</returns>
	virtual bool doesPasswordMatch(const std::string username, const std::string password) = 0;

	/// <summary>
	/// The function addds new user into database table
	/// </summary>
	/// <param name="username">username to add</param>
	/// <param name="password">password of the username</param>
	/// <param name="email">email of the username</param>
	virtual void addNewUser(const std::string username, const std::string password, const std::string email,
		const std::string address, const std::string phoneNumber, const std::string birthDate) = 0;

	/// <summary>
	/// The fucntion gets the questions from the database (with given amount) 
	/// </summary>
	/// <param name="questionsNumber">Amount of questions to get</param>
	/// <returns>List of the questions</returns>
	virtual std::list<Question> getQuestions(const int questionsNumber) = 0;

	virtual int getAmountOfQuestions() = 0;

	/// <summary>
	/// The function gives the average answer time of given player
	/// </summary>
	/// <param name="username">Name of user to get the info on</param>
	/// <returns>Average answer time</returns>
	virtual float getPlayerAverageAnswerTime(const std::string username) = 0;

	/// <summary>
	/// The function gives the amount of correct answer a given player has
	/// </summary>
	/// <param name="username">Name of user to get the info on</param>
	/// <returns>Amount of correct answers</returns>
	virtual int getNumOfCorrectAnswers(const std::string username) = 0;

	/// <summary>
	/// The function gives the amount of questions in the databse
	/// </summary>
	/// <returns>Amount of questions</returns>
	virtual int getNumOfWrongAnswers(const string username) = 0;

	/// <summary>
	/// The function gives the total amount of answers a given player has
	/// </summary>
	/// <param name="username">Name of user to get the info on</param>
	/// <returns>Total amount of answers</returns>
	virtual int getNumOfTotalAnswers(const std::string username) = 0;

	/// <summary>
	/// The function gives the amount of games a given player played
	/// </summary>
	/// <param name="username">Name of user to get the info on</param>
	/// <returns>Amount of games a player played</returns>
	virtual int getNumOfPlayerGames(const std::string username) = 0;

	/// <summary>
	/// The function sets the given player's average answer time to a new given value
	/// </summary>
	/// <param name="username">Name of user to change</param>
	/// <param name="new_avg_time">New average time</param>
	virtual void setPlayerAverageAnswerTime(const std::string username, const float new_avg_time) = 0;

	/// <summary>
	/// The function sets the given player's correct answers count to a new given value
	/// </summary>
	/// <param name="username">Name of user to change</param>
	/// <param name="new_correct_answers">New correct answer count</param>
	virtual void setNumOfCorrectAnswers(const std::string username, const int new_correct_answers) = 0;

	/// <summary>
	/// The function sets the given player's wrong answers count to a new given value
	/// </summary>
	/// <param name="username">Name of user to change</param>
	/// <param name="new_wrong_answers">New wrong answer count</param>
	virtual void setNumOfWrongAnswers(const std::string username, const int new_wrong_answers) = 0;

	/// <summary>
	/// The function sets the given player's games count to a new given value
	/// </summary>
	/// <param name="username">Name of user to change</param>
	/// <param name="new_num_games">New games count</param>
	virtual void setNumOfPlayerGames(const std::string username, const int new_num_games) = 0;

	/// <summary>
	/// The function gives all the users in the database
	/// </summary>
	/// <returns>List of all the users in the database</returns>
	virtual std::list<std::string> getUsers() = 0;

	/// <summary>
	/// The fucntion adds the given function to the db
	/// </summary>
	/// <param name="question">The question</param>
	/// <param name="c_answer1">Correct answer</param>
	/// <param name="w_answer2">First wrong answer</param>
	/// <param name="w_answer3">Second wrong answer</param>
	/// <param name="w_answer4">Third wrong answer</param>
	virtual void addQuestion(const string question, const string c_answer1, const string w_answer2, const string w_answer3, const string w_answer4) = 0;


};