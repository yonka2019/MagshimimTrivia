#include "Helper.h"
#include <iostream>

void Helper::sendData(const SOCKET sc, const string message)
{
	const char* data = message.c_str();

	if (send(sc, data, message.size(), 0) == INVALID_SOCKET)
	{
		throw exception("Error while sending message to client");
	}
}

