#include "LoginRequestHandler.h"

LoginRequestHandler::LoginRequestHandler(LoginManager& loginManager, RequestHandlerFactory& handlerFactory) : m_loginManager(loginManager), m_handlerFactory(handlerFactory)
{}


bool LoginRequestHandler::isRequestRelevant(const RequestInfo request) const
{
    return (request.id == LOGIN_REQUEST) || (request.id == SIGNUP_REQUEST); // check if request is relevant
}


RequestResult LoginRequestHandler::handleRequest(const RequestInfo request, const SOCKET socket) const
{
	try
	{
		if (request.id == LOGIN_REQUEST) // login
		{
			return this->login(request, socket);
		}

		else if (request.id == SIGNUP_REQUEST) // signup
		{
			return this->signup(request);
		}
	}

	catch (nlohmann::json::exception& e) // json error
	{
		ErrorResponse res = { "[ERROR] Request contains invalid json" };
		return { JsonResponsePacketSerializer::serializeResponse(res), nullptr };
	}

	catch (std::exception& e) // different error
	{
		ErrorResponse res = { e.what() };
		return { JsonResponsePacketSerializer::serializeResponse(res), nullptr };
	}
}


RequestResult LoginRequestHandler::login(const RequestInfo request, const SOCKET socket) const
{
	LoginRequest req = JsonRequestPacketDeserializer::deserializeLoginRequest(request.buffer);
	this->m_loginManager.login(req.username, req.password, socket); // trying to login 
	LoginResponse res = { LOGIN_RESPONSE };
	return { JsonResponsePacketSerializer::serializeResponse(res), (IRequestHandler*)this->m_handlerFactory.createMenuRequestHandler(req.username, socket)};
}


RequestResult LoginRequestHandler::signup(const RequestInfo request) const
{
	SignupRequest req = JsonRequestPacketDeserializer::deserializeSignupRequest(request.buffer);
	this->m_loginManager.signup(req.username, req.password, req.email, req.address, req.phoneNumber, req.birthDate); // trying to signup
	SignupResponse res = { SIGNUP_RESPONSE };
	return { JsonResponsePacketSerializer::serializeResponse(res), (IRequestHandler*)this->m_handlerFactory.createLoginRequestHandler()};
}