#include "RequestHandlerFactory.h"

RequestHandlerFactory::RequestHandlerFactory(IDatabase* db): m_database(db), m_roomManager(), m_StatisticsManager(db), m_gameManager(db)
{
}


RequestHandlerFactory::~RequestHandlerFactory()
{
}


LoginRequestHandler* RequestHandlerFactory::createLoginRequestHandler()
{
    return new LoginRequestHandler(LoginManager::getInstance(this->m_database), *this);
}


MenuRequestHandler* RequestHandlerFactory::createMenuRequestHandler(const string username, const SOCKET socket)
{
    return new MenuRequestHandler(username, socket , this->m_roomManager, this->m_StatisticsManager, *this);
}


RoomAdminRequestHandler* RequestHandlerFactory::createRoomAdminRequestHandler(const string username, const SOCKET socket, const int roomId)
{
    return new RoomAdminRequestHandler(username, socket, this->m_roomManager, *this, roomId);
}


RoomMemberRequestHandler* RequestHandlerFactory::createRoomMemberRequestHandler(const string username, const SOCKET socket, const int roomId)
{
    return new RoomMemberRequestHandler(username, socket, this->m_roomManager, *this, roomId);
}


GameRequestHandler* RequestHandlerFactory::createGameRequestHandler(const string username, const SOCKET socket, Game& game)
{
    return new GameRequestHandler(username, socket, this->m_gameManager, *this, game);
}


LoginManager& RequestHandlerFactory::getLoginManager()
{
    return LoginManager::getInstance(this->m_database);
}


StatisticsManager& RequestHandlerFactory::getStatisticsManager()
{
    return this->m_StatisticsManager;
}


RoomManager& RequestHandlerFactory::getRoomManager()
{
    return this->m_roomManager;
}


GameManager& RequestHandlerFactory::getGameManager()
{
    return this->m_gameManager;
}


IDatabase* RequestHandlerFactory::getDataBase()
{
    return this->m_database;
}
