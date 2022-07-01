#pragma once
#include "Room.h"
#include <map>
#include <mutex>

using std::mutex;

class RoomManager
{
public:
	RoomManager();
	~RoomManager() = default;

	/// <summary>
	/// The function creates a new room
	/// </summary>
	/// <param name="user">User that created the room</param>
	/// <param name="room">The room's details</param>
	void createRoom(const LoggedUser user, RoomData& room);

	/// <summary>
	/// The function deletes a room
	/// </summary>
	/// <param name="ID">Id of the room to delete</param>
	void deleteRoom(const int ID);

	/// <summary>
	/// The function gives the room's state (active or not)
	/// </summary>
	/// <param name="ID">Id of room to check</param>
	/// <returns>Active or not</returns>
	unsigned int getRoomState(const int ID) const;

	/// <summary>
	/// The function gives all the rooms
	/// </summary>
	/// <returns>All the rooms' details</returns>
	std::vector<RoomData> getRooms() const;

	/// <summary>
	/// The function checks if a room with the given id exists
	/// </summary>
	/// <param name="ID">Id of room to check</param>
	/// <returns>True if exists, false if not</returns>
	bool hasRoom(const int ID) const;

	/// <summary>
	/// The function gives the room with the given id
	/// </summary>
	/// <param name="ID">Id of room to get</param>
	/// <returns></returns>
	Room& getRoom(const int ID);

private:
	std::map<unsigned int, Room> m_rooms;
	int lastUsedId;
	mutable mutex rooms_mtx;
};