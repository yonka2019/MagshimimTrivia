#pragma once

#include "Requests.h"
#include <WinSock2.h>

class IRequestHandler
{
public:
	/// <summary>
	/// The function checks if the given request is relevant to the current handler
	/// </summary>
	/// <param name="">Request info object</param>
	/// <returns>True if relevant. False if not</returns>
	virtual bool isRequestRelevant(const RequestInfo) const = 0;

	/// <summary>
	/// The function handles the given request
	/// </summary>
	/// <param name="">RequestInfo object</param>
	/// <param name="">Socket</param>
	/// <returns>RequestResult object</returns>
	virtual RequestResult handleRequest(const RequestInfo, const SOCKET) const = 0;
private:
};