#include "RoomMemberRequestHandler.h"

RoomMemberRequestHandler::RoomMemberRequestHandler(const string username, const SOCKET socket, RoomManager& roomManager, RequestHandlerFactory& factory, const int roomId) : m_user(username, socket), m_roomManager(roomManager), m_handlerFactory(factory), m_room(roomManager.getRoom(roomId))
{
}


bool RoomMemberRequestHandler::isRequestRelevant(const RequestInfo request) const
{
	return (request.id == LEAVE_ROOM_REQEUST) || (request.id == GET_ROOM_STATE_REQUEST); // check if request is relevant
}


RequestResult RoomMemberRequestHandler::handleRequest(const RequestInfo request, const SOCKET socket) const
{
	try
	{
		if (request.id == LEAVE_ROOM_REQEUST) // leave room
		{
			return this->leaveRoom(request);
		}

		else if (request.id == GET_ROOM_STATE_REQUEST) // get room state
		{
			return this->getRoomState(request);
		}
	}

	catch (nlohmann::json::exception& e) // json error
	{
		ErrorResponse res = { "[ERROR] Request contains invalid json" };
		return { JsonResponsePacketSerializer::serializeResponse(res), nullptr };
	}

	catch (std::exception& e) // different error
	{
		ErrorResponse res = { e.what() };
		return { JsonResponsePacketSerializer::serializeResponse(res), nullptr };
	}
}


RequestResult RoomMemberRequestHandler::leaveRoom(const RequestInfo request) const
{
	LeaveRoomResponse res = { LEAVE_ROOM_RESPONSE };

	this->m_roomManager.getRoom(this->m_room.getMetaData().id).removeUser(this->m_user);

	return { JsonResponsePacketSerializer::serializeResponse(res), (IRequestHandler*)this->m_handlerFactory.createMenuRequestHandler(this->m_user.getUsername(), this->m_user.getSocket()) };
}


RequestResult RoomMemberRequestHandler::getRoomState(const RequestInfo request) const
{
	if (this->m_roomManager.hasRoom(this->m_room.getMetaData().id))
	{
		GetRoomStateResponse res = { GET_ROOM_STATE_REQUEST,
			this->m_roomManager.getRoomState(this->m_room.getMetaData().id),
			this->m_room.getAllUsers(),
			this->m_room.getMetaData().numOfQuestionsInGame,
			this->m_room.getMetaData().timePerQuestion,
			this->m_room.getMetaData().maxPlayers };

		return { JsonResponsePacketSerializer::serializeResponse(res), (IRequestHandler*)this->m_handlerFactory.createRoomMemberRequestHandler(this->m_user.getUsername(), this->m_user.getSocket(), this->m_room.getMetaData().id) };
	}
	else
	{
		vector<char> null_packet;
		null_packet.push_back(static_cast<unsigned char>(' '));
		return { null_packet, (IRequestHandler*)this->m_handlerFactory.createMenuRequestHandler(this->m_user.getUsername(), this->m_user.getSocket()) };
	}
}
