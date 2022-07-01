#pragma once

#include <iostream>
#include <map>
#include <thread>
#include <WinSock2.h>
#include "LoginRequestHandler.h"
#include "Helper.h"
#include <exception>
#include "RequestHandlerFactory.h"

using std::cout;
using std::endl;
using std::cin;

using std::map;
using std::thread;
using std::exception;

#define PORT 9300

#define CODE_BUFFER_SIZE 2 // (1 byte length, because the length is convert into hex, 1 * 2 = 2 ==> 2 bytes)
#define LENGTH_BUFFER_SIZE 8 // (4 bytes length, because the length is converted into hex, 4 * 2 = 8 ==> 8 bytes)
#define MESSAGE_BASE 16 // 16 - HEXADECIMAL

class RequestHandlerFactory;

class Communicator
{
public:
	static Communicator& getInstance(RequestHandlerFactory& factory_handle)
	{
		static Communicator instance(factory_handle);
		return instance;
	}
	// delete copy constructor and assignment operator for singleton
	Communicator(Communicator const&) = delete;
	void operator=(Communicator const&) = delete;

	/// <summary>
	/// The function closes the server's socket
	/// </summary>
	~Communicator();

	/// <summary>
	/// The function handles the clients' requests (connecting)
	/// </summary>
	void startHandleRequests();

	/// <summary>
	/// The function gives all the clients
	/// </summary>
	/// <returns>The clients</returns>
	map<SOCKET, IRequestHandler*>& getClients();
private:
	/// <summary>
	/// The function opens the server's socket
	/// </summary>
	Communicator(RequestHandlerFactory& factory_handle);

	/// <summary>
	/// The function handles the conversation between the server and the client
	/// </summary>
	/// <param name="socket">Socket of the current client</param>
	void handleNewClient(const SOCKET socket);

	/// <summary>
	/// The function binds the port and listens to new connections
	/// </summary>
	/// <param name="port">Port of the server</param>
	void bindAndListen(const int port);

	/// <summary>
	/// The function gives the data's code
	/// </summary>
	/// <param name="socket">Socket of the current client</param>
	/// <returns>Data's code</returns>
	int getCode(const SOCKET socket) const;

	/// <summary>
	/// The function gives the data's length
	/// </summary>
	/// <param name="socket">Socket of the current client</param>
	/// <returns>Data's length</returns>
	int getLengthOfData(const SOCKET socket) const;

	/// <summary>
	/// The function gives the data of the packet
	/// </summary>
	/// <param name="socket">Socket of the current client</param>
	/// <param name="length">Length of the data</param>
	/// <returns>The data</returns>
	vector<unsigned char> getData(const SOCKET socket, const int length) const;

	/// <summary>
	/// The function prints the type of request based on its code
	/// </summary>
	/// <param name="code">Code of request</param>
	void printRequestType(const int code) const;

	SOCKET m_serverSocket;
	map<SOCKET, IRequestHandler*> m_clients;
	RequestHandlerFactory& m_handlerFactory;
};

