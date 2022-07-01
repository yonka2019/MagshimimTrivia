#pragma once

#include "IRequestHandler.h"
#include "jsonRequestPacketDeserializer.h"
#include "JsonResponsePacketSerializer.h"
#include "Requests.h"
#include "LoginManager.h"
#include "RequestHandlerFactory.h"

class RequestHandlerFactory;

class LoginRequestHandler : IRequestHandler
{
public:
	
	LoginRequestHandler(LoginManager& loginManager, RequestHandlerFactory& handlerFactory);


	/// <summary>
	/// The function checks if the request is a login or signup one
	/// </summary>
	/// <param name="request">Request to check</param>
	/// <returns>True if is, false if isn't</returns>
	bool isRequestRelevant(const RequestInfo request) const override;


	/// <summary>
	/// The function gets a request and returns a "RequestResult" object (holds the response)
	/// </summary>
	/// <param name="request">A request</param>
	/// <returns>"RequestResult" object</returns>
	RequestResult handleRequest(const RequestInfo request, const SOCKET socket) const override;


private:
	/// <summary>
	/// The function tries to login with the request's info
	/// </summary>
	/// <param name="request">RequestInfo object</param>
	/// <returns>RequestResult object</returns>
	/// 
	RequestResult login(const RequestInfo request, const SOCKET socket) const;


	/// <summary>
	/// The function tries to signup with the request's info
	/// </summary>
	/// <param name="request">RequestInfo object</param>
	/// <returns>RequestResult object</returns>
	RequestResult signup(const RequestInfo request) const;


	LoginManager& m_loginManager;
	RequestHandlerFactory& m_handlerFactory;
};

