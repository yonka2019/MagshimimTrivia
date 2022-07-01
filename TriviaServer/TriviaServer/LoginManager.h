#pragma once

#include <iostream>
#include <vector>
#include "IDatabase.h"
#include "LoggedUser.h"
#include <string>
#include <regex>
#include <mutex>
#include <unordered_map>
#include <vector>

using std::vector;
using std::unordered_map;
using std::regex;
using std::pair;
using std::string;
using std::exception;
using std::mutex;

#define REGEX_PASSWORD R"(^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-])\S{8,}$)"
#define REGEX_EMAIL R"((?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|"(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\]))"
#define REGEX_ADDRESS R"(^\([a-zA-Z]+, \d+, [a-zA-Z]+\)$)"
#define REGEX_PHONE_NUMBER R"(^0\d{1,2}\d{7,8}$)"
#define REGEX_BIRTH_DATE R"(^\d{1,2}(\.|\/)\d{1,2}(\.|\/)\d{4}$)"


class LoginManager
{
public:
	static LoginManager& getInstance(IDatabase* db)
	{
		static LoginManager instance(db);
		return instance;
	}
	// delete copy constructor and assignment operator for singleton
	LoginManager(LoginManager const&) = delete;
	void operator=(LoginManager const&) = delete;

	~LoginManager();

	/// <summary>
	/// logins the given username into the system (if the user isn't already logged in and the password matches the sql record)
	/// </summary>
	/// <param name="username">username to log in</param>
	/// <param name="password">username's password</param>
	void login(const std::string username, const std::string password, const SOCKET socket);

	/// <summary>
	/// signs up the given username into the system and into the database according his data
	/// </summary>
	/// <param name="username">username to sign up (str)</param>
	/// <param name="password">username's password (str data)</param>
	/// <param name="email">username's email (str data)</param>
	/// <param name="address">username's adress (str data)</param>
	/// <param name="phoneNumber">username's phone number (str data)</param>
	/// <param name="birthDate">username's birthdate (str data)</param>
	void signup(const std::string username, const std::string password, const std::string email,
		const std::string address, const std::string phoneNumber, const std::string birthDate);

	/// <summary>
	/// logging out the given username
	/// </summary>
	/// <param name="username">username to log out</param>
	void logout(const std::string username);

private:
	LoginManager(IDatabase* db);

	/// <summary>
	/// current active database
	/// </summary>
	IDatabase* m_database;

	/// <summary>
	/// vector (list) of current active logged users
	/// </summary>
	static std::vector<LoggedUser> m_loggedUsers;
	mutex users_mtx;
};