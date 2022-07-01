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
#include "GameManager.h"
#include <mutex>

class RequestHandlerFactory;

class GameRequestHandler : public IRequestHandler
{
public:
	GameRequestHandler(const string username, const SOCKET socket, GameManager& gameManager, RequestHandlerFactory& factory, Game& game);
	bool isRequestRelevant(const RequestInfo request) const override;
	RequestResult handleRequest(const RequestInfo request, const SOCKET socket) const override;

private:

	/// <summary>
	/// The function gets the question
	/// </summary>
	/// <param name="request">RequestInfo object</param>
	/// <returns>RequestResult object</returns>
	/// 
	RequestResult getQuestion(const RequestInfo request) const;

	/// <summary>
	/// The function submits the answer
	/// </summary>
	/// <param name="request">RequestInfo object</param>
	/// <returns>RequestResult object</returns>
	/// 
	RequestResult submitAnswer(const RequestInfo request) const;

	/// <summary>
	/// The function gets the game's results
	/// </summary>
	/// <param name="request">RequestInfo object</param>
	/// <returns>RequestResult object</returns>
	/// 
	RequestResult getGameResults(const RequestInfo request) const;

	/// <summary>
	/// The function leaves the game
	/// </summary>
	/// <param name="request">RequestInfo object</param>
	/// <returns>RequestResult object</returns>
	/// 
	RequestResult leaveGame(const RequestInfo request) const;

	void saveResultsInDb(const std::pair<LoggedUser, const GameData> player) const;

	LoggedUser m_user;
	Game& m_game;
	GameManager& m_gameManager;
	RequestHandlerFactory& m_handlerFactory;
	mutable mutex mutexUsersCounter;
};

