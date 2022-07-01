#include "Room.h"

Room::Room(RoomData data)
{
	this->m_metadata = data;
}

Room::Room(const Room& room)
{
	this->m_metadata = room.m_metadata;
	this->m_users = room.m_users;
}


void Room::addUser(const LoggedUser user)
{
	this->users_mtx.lock();

	if (this->m_users.size() >= this->m_metadata.maxPlayers) // check if room full
	{
		this->users_mtx.unlock();
		throw std::exception("[ERROR] Room is full");
	}

	else if (std::find(this->m_users.begin(), this->m_users.end(), user) != this->m_users.end()) // check if user already exists in room
	{
		this->users_mtx.unlock();
		throw std::exception("[ERROR] User already exists in this room");
	}

	else
	{
		this->m_users.push_back(user); // add to room
		this->users_mtx.unlock();
	}
}


void Room::removeUser(const LoggedUser user)
{
	this->users_mtx.lock();

	bool exist = false;
	auto it = this->m_users.begin();

	while (it != this->m_users.end() && !exist) // search the user in the vector of users
	{
		if (it->getUsername() == user.getUsername())
			exist = true;
		else
			it++;
	}

	if (exist)
	{
		this->m_users.erase(it); // remove the user from the vector of users
		this->users_mtx.unlock();
	}

	else
	{
		this->users_mtx.unlock();
		throw std::exception("[ERROR] This user doesn't exist in this room");
	}
}


std::vector<std::string> Room::getAllUsers() const
{
	this->users_mtx.lock();

	std::vector<std::string> userNames = {};
	for (auto const& user : this->m_users)
	{
		userNames.push_back(user.getUsername());
	}

	this->users_mtx.unlock();
	return userNames;
}


std::vector<LoggedUser> Room::getAllLoggedUsers() const
{
	return this->m_users;
}


RoomData& Room::getMetaData() const
{
	return this->m_metadata;
}