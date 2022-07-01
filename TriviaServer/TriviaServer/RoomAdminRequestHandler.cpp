#include "RoomAdminRequestHandler.h"

RoomAdminRequestHandler::RoomAdminRequestHandler(const string username, const SOCKET socket, RoomManager& roomManager, RequestHandlerFactory& factory, const int roomId) : m_user(username, socket), m_roomManager(roomManager), m_handlerFactory(factory), m_room(roomManager.getRoom(roomId))
{
}


bool RoomAdminRequestHandler::isRequestRelevant(const RequestInfo request) const
{
	return (request.id == CLOSE_ROOM_REQUEST) ||
		(request.id == START_GAME_REQUEST) ||
		(request.id == GET_ROOM_STATE_REQUEST); // check if request is relevant
}


RequestResult RoomAdminRequestHandler::handleRequest(const RequestInfo request, const SOCKET socket) const
{
	try
	{
		if (request.id == CLOSE_ROOM_REQUEST) // close room
		{
			return this->closeRoom(request);
		}

		else if (request.id == START_GAME_REQUEST) // start rooms
		{
			return this->startGame(request);
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


RequestResult RoomAdminRequestHandler::closeRoom(const RequestInfo request) const
{
	CloseRoomResponse res = { CLOSE_ROOM_RESPONSE };

	for (auto& user : this->m_room.getAllLoggedUsers()) // send all the players a LEAVE GAME RESPONSE
	{
		LeaveRoomResponse leave_res = { LEAVE_ROOM_RESPONSE };

		this->m_roomManager.getRoom(this->m_room.getMetaData().id).removeUser(user);


		vector<char> serialized_res = JsonResponsePacketSerializer::serializeResponse(leave_res);
		string serizlized_res_str(serialized_res.begin(), serialized_res.end());
		Helper::sendData(user.getSocket(), serizlized_res_str);
	}
	this->m_roomManager.deleteRoom(this->m_room.getMetaData().id);

	return { JsonResponsePacketSerializer::serializeResponse(res), (IRequestHandler*)this->m_handlerFactory.createMenuRequestHandler(this->m_user.getUsername(), this->m_user.getSocket()) };
}


RequestResult RoomAdminRequestHandler::startGame(const RequestInfo request) const
{
	StartGameResponse res = { START_GAME_RESPONSE };

	map<SOCKET, IRequestHandler*>& clients = Communicator::getInstance(this->m_handlerFactory).getClients();

	Game& current_game = this->m_handlerFactory.getGameManager().createGame(this->m_room);
	
	for (auto& user : this->m_room.getAllLoggedUsers()) // send all players a START GAME RESPONSE
	{
		clients[user.getSocket()] = this->m_handlerFactory.createGameRequestHandler(user.getUsername(), user.getSocket(), current_game); // change players' handlers to GameRequestHandler

		StartGameResponse start_game_res = { START_GAME_RESPONSE };
		vector<char> serialized_res = JsonResponsePacketSerializer::serializeResponse(start_game_res);
		string serizlized_res_str(serialized_res.begin(), serialized_res.end());
		Helper::sendData(user.getSocket(), serizlized_res_str);

	}

	this->m_room.getMetaData().isActive = 0;
	return { JsonResponsePacketSerializer::serializeResponse(res), (IRequestHandler*)this->m_handlerFactory.createGameRequestHandler(this->m_user.getUsername(), this->m_user.getSocket(), current_game)};
}


RequestResult RoomAdminRequestHandler::getRoomState(const RequestInfo request) const
{
	GetRoomStateResponse res = { GET_ROOM_STATE_REQUEST, 
		this->m_roomManager.getRoomState(this->m_room.getMetaData().id), 
		this->m_room.getAllUsers(), 
		this->m_room.getMetaData().numOfQuestionsInGame,
		this->m_room.getMetaData().timePerQuestion,
		this->m_room.getMetaData().maxPlayers};

	return { JsonResponsePacketSerializer::serializeResponse(res), (IRequestHandler*)this->m_handlerFactory.createRoomAdminRequestHandler(this->m_user.getUsername(), this->m_user.getSocket(), this->m_room.getMetaData().id) };
}
