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

class MenuRequestHandler : public IRequestHandler
{
public:
	MenuRequestHandler(const string username, const SOCKET socket, RoomManager& roomManager, StatisticsManager& statisticsManager, RequestHandlerFactory& factory);
	bool isRequestRelevant(const RequestInfo request) const override;
	RequestResult handleRequest(const RequestInfo request, const SOCKET socket) const override;

private:

	/// <summary>
	/// The function signs out (based on the request)
	/// </summary>
	/// <param name="request">RequestInfo object</param>
	/// <returns>RequestResult object</returns>
	/// 
	RequestResult signout(const RequestInfo request) const;

	/// <summary>
	/// The function gets all the rooms
	/// </summary>
	/// <param name="request">RequestInfo object</param>
	/// <returns>RequestResult object</returns>
	RequestResult getRooms(const RequestInfo request) const;

	/// <summary>
	/// The function gets all the players in a room (based on the request)
	/// </summary>
	/// <param name="request">RequestInfo object</param>
	/// <returns>RequestResult object</returns>
	RequestResult getPlayersInRoom(const RequestInfo request) const;

	/// <summary>
	/// The function gets all the personal statistics of a user
	/// </summary>
	/// <param name="request">RequestInfo object</param>
	/// <returns>RequestResult object</returns>
	RequestResult getPersonalStats(const RequestInfo request) const;

	/// <summary>
	/// The function gets the highscore table (first 5 users with the hightes scores)
	/// </summary>
	/// <param name="request">RequestInfo object</param>
	/// <returns>RequestResult object</returns>
	RequestResult getHighScore(const RequestInfo request) const;

	/// <summary>
	/// The function tries to enter into a room (based on the request)
	/// </summary>
	/// <param name="request">RequestInfo object</param>
	/// <returns>RequestResult object</returns>
	RequestResult joinRoom(const RequestInfo request) const;

	/// <summary>
	/// The function tries to create a room (based on the request)
	/// </summary>
	/// <param name="request">RequestInfo object</param>
	/// <returns>RequestResult object</returns>
	RequestResult createRoom(const RequestInfo request) const;

	
	/// <summary>
	/// The function adds a question to the database
	/// </summary>
	/// <param name="request">RequestInfo object</param>
	/// <returns>RequestResult object</returns>
	RequestResult addQuestion(const RequestInfo request) const;

	/// <summary>
	/// The function gives the proper error message
	/// </summary>
	/// <param name="req">CreateRoomRequest object</param>
	/// <param name="amount_of_questions">Amount of questions in the db</param>
	/// <returns>Proper error message based on the given data</returns>
	string getErrorMessage(const CreateRoomRequest req, const int amount_of_questions) const;

	LoggedUser m_user;
	RoomManager& m_roomManager;
	StatisticsManager& m_statisticsManager;
	RequestHandlerFactory& m_handlerFactory;
};

