#pragma comment (lib, "ws2_32.lib")

#include "Server.h"
#include "WSAInitializer.h"
#include "JsonResponsePacketSerializer.h"
#include "jsonRequestPacketDeserializer.h"
#include "SqliteDataBase.h"

int main()
{
	try
	{
		std::cout << "[INFO] Starting..." << std::endl;
		WSAInitializer wsa_init;
		SqliteDataBase* db = &SqliteDataBase::getInstance();
		Server::getInstance(db).run();
	}

	catch (const std::exception& e)
	{
		std::cout << "Exception was thrown in function: " << e.what() << std::endl;
	}

	catch (...)
	{
		std::cout << "Unknown exception in main !" << std::endl;
	}
}
