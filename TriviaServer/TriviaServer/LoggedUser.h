#pragma once

#include <iostream>
#include <WinSock2.h>

class LoggedUser
{
public:
	LoggedUser(const std::string username, const SOCKET socket);
	~LoggedUser() = default;

	/// <summary>
	/// The function gives the current username
	/// </summary>
	/// <returns>Current username</returns>
	std::string getUsername() const;

	/// <summary>
	/// The function gives the user's socket
	/// </summary>
	/// <returns>User's socket</returns>
	SOCKET getSocket() const;

	/// <summary>
	/// The fucntion compares between two LoggedUsers
	/// </summary>
	/// <param name="user">Another user to compare between</param>
	/// <returns>True if they both have the same names</returns>
	bool operator==(const LoggedUser user) const;
	
	/// <summary>
	/// The function compares between ttwo LoggedUsers (the function was made so the LoggedUser could be in a "map")
	/// </summary>
	/// <param name="other">Another user to compare between</param>
	/// <returns>True if current player's name is shorter than the other player's name</returns>
	bool operator<(const LoggedUser& other) const;
	

private:
	std::string m_username;
	SOCKET m_socket;
};