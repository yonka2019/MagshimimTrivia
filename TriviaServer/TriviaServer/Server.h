#pragma once

#include <iostream>
#include <string>
#include <thread>
#include <WinSock2.h>
#include "LoginRequestHandler.h"
#include "Helper.h"
#include "Communicator.h"
#include "IDatabase.h"
#include "RequestHandlerFactory.h"

#define TRACE(msg, ...) printf(msg "\n", __VA_ARGS__);

using std::string;
using std::thread;

class Server
{
public:
	static Server& getInstance(IDatabase* db)
	{
		static Server instance(db);
		return instance;
	}
	// delete copy constructor and assignment operator for singleton
	Server(Server const&) = delete;
	void operator=(Server const&) = delete;

	/// <summary>
	/// The function opens listening thread for connecting with clients
	/// </summary>
	void run() const;

private:
	Server(IDatabase* db);

	IDatabase* m_database;
};

