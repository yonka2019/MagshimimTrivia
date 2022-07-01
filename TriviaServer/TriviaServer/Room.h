#pragma once

#include <string>
#include <vector>
#include <iostream>
#include <vector>
#include <mutex>
#include "LoggedUser.h"

using std::string;
using std::vector;
using std::mutex;

typedef struct RoomData
{
	unsigned int id;
	string name;
	unsigned int maxPlayers;
	unsigned int numOfQuestionsInGame;
	unsigned int timePerQuestion;
	unsigned int isActive;
} RoomData;

class Room
{
public:
	Room(RoomData data);
	Room(const Room& room);

	~Room() = default;

	/// <summary>
	/// The function adds a given user to the room
	/// </summary>
	/// <param name="user">User to add</param>
	void addUser(const LoggedUser user);

	/// <summary>
	/// The function removes a given user of the room
	/// </summary>
	/// <param name="user">User to remove</param>
	void removeUser(const LoggedUser user);

	/// <summary>
	/// The function gives all the users' names in the room
	/// </summary>
	/// <returns>All of the users' names in the room</returns>
	vector<string> getAllUsers() const;

	/// <summary>
	/// The fucntion gives all the users in the room
	/// </summary>
	/// <returns>Users in the room</returns>
	vector<LoggedUser> getAllLoggedUsers() const;

	/// <summary>
	/// The function gives the room's data
	/// </summary>
	/// <returns>Room's data</returns>
	RoomData& getMetaData() const;

private:
	mutable RoomData m_metadata;
	vector<LoggedUser> m_users;
	mutable mutex users_mtx;
};