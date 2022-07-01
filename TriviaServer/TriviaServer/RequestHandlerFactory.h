#pragma once

#include "IRequestHandler.h"
#include "LoginManager.h"
#include "LoginRequestHandler.h"
#include "IDatabase.h"
#include "MenuRequestHandler.h"
#include "StatisticsManager.h"
#include "RoomManager.h"
#include "RoomAdminRequestHandler.h"
#include "RoomMemberRequestHandler.h"
#include "GameManager.h"
#include "GameRequestHandler.h"


class LoginRequestHandler;
class MenuRequestHandler;
class RoomAdminRequestHandler;
class RoomMemberRequestHandler;
class GameRequestHandler;

class RequestHandlerFactory
{
public:
	static RequestHandlerFactory& getInstance(IDatabase* db)
	{
		static RequestHandlerFactory instance(db);
		return instance;
	}
	// delete copy constructor and assignment operator for singleton
	RequestHandlerFactory(RequestHandlerFactory const&) = delete;
	void operator=(RequestHandlerFactory const&) = delete;

	~RequestHandlerFactory();

	/// <summary>
	/// The function creates a "LoginRequestHandler" object
	/// </summary>
	/// <returns>LoginRequestHandler object pointer</returns>
	LoginRequestHandler* createLoginRequestHandler();

	/// <summary>
	/// The function creates a "MenuRequestHandler" object
	/// </summary>
	/// <param name="username">The current user's name</param>
	/// <returns>MenuRequestHandler object pointer</returns>
	MenuRequestHandler* createMenuRequestHandler(const string username, const SOCKET socket);

	/// <summary>
	/// The function creates a "RoomAdminRequestHandler" object
	/// </summary>
	/// <param name="username">The current user's name</param>
	/// <param name="socket">The current user's socket</param>
	/// <param name="roomId">The room Id</param>
	/// <returns>"RoomAdminRequestHandler" object</returns>
	RoomAdminRequestHandler* createRoomAdminRequestHandler(const string username, const SOCKET socket, const int roomId);

	/// <summary>
	/// The function creates a "RoomMemberRequestHandler" object
	/// </summary>
	/// <param name="username">The current user's name</param>
	/// <param name="socket">The current user's socket</param>
	/// <param name="roomId">The room Id</param>
	/// <returns>"RoomMemberRequestHandler" object</returns>
	RoomMemberRequestHandler* createRoomMemberRequestHandler(const string username, const SOCKET socket, const int roomId);

	/// <summary>
	/// The function creates a "GameRequestHandler" object
	/// </summary>
	/// <param name="username">The current user's name</param>
	/// <param name="socket">The current user's socket</param>
	/// <returns>"GameRequestHandler" object</returns>
	GameRequestHandler* createGameRequestHandler(const string username, const SOCKET socket, Game& game);

	/// <summary>
	/// The function gives the Login Manager
	/// </summary>
	/// <returns>LoginManager object</returns>
	LoginManager& getLoginManager();

	/// <summary>
	/// The function gives the Statistics Manager
	/// </summary>
	/// <returns>StatisticsManager object</returns>
	StatisticsManager& getStatisticsManager();

	/// <summary>
	/// The function gives the Room Manager
	/// </summary>
	/// <returns>RoomManager object</returns>
	RoomManager& getRoomManager();

	/// <summary>
	/// The function gives the Game Manager
	/// </summary>
	/// <returns>GameManager object</returns>
	GameManager& getGameManager();

	/// <summary>
	/// The function gives the database
	/// </summary>
	/// <returns>IDatabase object</returns>
	IDatabase* getDataBase();

private:
	RequestHandlerFactory(IDatabase* db);

	IDatabase* m_database;
	RoomManager m_roomManager;
	StatisticsManager m_StatisticsManager;
	GameManager m_gameManager;

};

