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

class RequestHandlerFactory;

class RoomMemberRequestHandler : public IRequestHandler
{
public:
	RoomMemberRequestHandler(const string username, const SOCKET socket, RoomManager& roomManager, RequestHandlerFactory& factory, const int roomId);
	bool isRequestRelevant(const RequestInfo request) const override;
	RequestResult handleRequest(const RequestInfo request, const SOCKET socket) const override;

private:

	/// <summary>
	/// The function leaves the room
	/// </summary>
	/// <param name="request">RequestInfo object</param>
	/// <returns>RequestResult object</returns>
	RequestResult leaveRoom(const RequestInfo request) const;

	/// <summary>
	/// The function gets the room's state
	/// </summary>
	/// <param name="request">RequestInfo object</param>
	/// <returns>RequestResult object</returns>
	RequestResult getRoomState(const RequestInfo request) const;


	Room m_room;
	LoggedUser m_user;
	RoomManager& m_roomManager;
	RequestHandlerFactory& m_handlerFactory;
};

