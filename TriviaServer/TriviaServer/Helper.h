#pragma once

#include <WinSock2.h>
#include <string>
#include <exception>


using std::string;
using std::exception;

class Helper
{
public:
	/// <summary>
	/// The function sends a given message to a given socket
	/// </summary>
	/// <param name="sc">Socket to send to</param>
	/// <param name="message">Message to send</param>
	static void sendData(const SOCKET sc, const std::string message);
};