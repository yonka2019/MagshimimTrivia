#pragma once

#include "IRequestHandler.h"
#include "jsonRequestPacketDeserializer.h"
#include "JsonResponsePacketSerializer.h"
#include "Requests.h"
#include "LoginManager.h"
#include "LoginRequestHandler.h"
#include "IDatabase.h"
#include "RequestHandlerFactory.h"
#include "RoomManager.h"
#include "StatisticsManager.h"
#include "Helper.h"
#include "Communicator.h"

class RequestHandlerFactory;

class RoomAdminRequestHandler : public IRequestHandler
{
public:
	RoomAdminRequestHandler(const string username, const SOCKET socket, RoomManager& roomManager, RequestHandlerFactory& factory, const int roomId);
	bool isRequestRelevant(const RequestInfo request) const override;
	RequestResult handleRequest(const RequestInfo request, const SOCKET socket) const override;

private:

	/// <summary>
	/// The function closes the room
	/// </summary>
	/// <param name="request">RequestInfo object</param>
	/// <returns>RequestResult object</returns>
	RequestResult closeRoom(const RequestInfo request) const;

	/// <summary>
	/// The function starts the game
	/// </summary>
	/// <param name="request">RequestInfo object</param>
	/// <returns>RequestResult object</returns>
	RequestResult startGame(const RequestInfo request) const;

	/// <summary>
	/// The function gets the room's state
	/// </summary>
	/// <param name="request">RequestInfo object</param>
	/// <returns>RequestResult object</returns>
	RequestResult getRoomState(const RequestInfo request) const;


	Room& m_room;
	LoggedUser m_user;
	RoomManager& m_roomManager;
	RequestHandlerFactory& m_handlerFactory;
};

