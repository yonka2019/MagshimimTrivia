#include "RoomManager.h"

RoomManager::RoomManager()
{
	this->lastUsedId = 0;
}


void RoomManager::createRoom(const LoggedUser user, RoomData& room)
{
	room.id = this->lastUsedId++;
	Room newRoom(room);
	newRoom.addUser(user);

	this->rooms_mtx.lock();
	this->m_rooms.insert({room.id, newRoom});
	this->rooms_mtx.unlock();

}


void RoomManager::deleteRoom(const int ID)
{
	this->rooms_mtx.lock();
	this->m_rooms.erase(this->m_rooms.find(ID));
	this->rooms_mtx.unlock();

}


unsigned int RoomManager::getRoomState(const int ID) const
{
	return this->m_rooms.find(ID)->second.getMetaData().isActive;
}


std::vector<RoomData> RoomManager::getRooms() const
{
	std::vector<RoomData> roomDataList = {};

	this->rooms_mtx.lock();
	for (auto const& room : this->m_rooms)
	{
		roomDataList.push_back(room.second.getMetaData()); // add data of room
	}
	this->rooms_mtx.unlock();

	return roomDataList;
}


bool RoomManager::hasRoom(const int ID) const
{
	return this->m_rooms.find(ID) != this->m_rooms.end();
}


Room& RoomManager::getRoom(const int ID)
{
	this->rooms_mtx.lock();
	for (auto& room : this->m_rooms)
	{
		if (room.first == ID) // search room by id
		{
			this->rooms_mtx.unlock();
			return room.second;
		}
	}

	this->rooms_mtx.unlock();

}
