#include "Communicator.h"


Communicator::Communicator(RequestHandlerFactory& factory_handle): m_handlerFactory(factory_handle)
{
	this->m_serverSocket = ::socket(AF_INET, SOCK_STREAM, IPPROTO_TCP);
	if (this->m_serverSocket == INVALID_SOCKET)
		throw exception(__FUNCTION__ " - socket");
}


Communicator::~Communicator()
{
	cout << __FUNCTION__ " closing accepting socket" << endl;

	try
	{
		::closesocket(this->m_serverSocket);

		for (auto client = m_clients.begin(); client != m_clients.end(); client++) // deleting clients
		{
			delete[] client->second;
		}
	}
	catch (...) {}
}


void Communicator::startHandleRequests()
{
	bindAndListen(PORT);

	while (true)
	{
		SOCKET client_socket = accept(this->m_serverSocket, NULL, NULL);

		if (client_socket == INVALID_SOCKET)
		{
			cout << "[ERROR] Didn't connect" << endl;
			throw exception(__FUNCTION__);
		}

		cout << "\n[INFO] [" << this->m_clients.size() + 1 << "] client connected. Server and client can speak" << endl;

		this->m_clients[client_socket] = (IRequestHandler*) new LoginRequestHandler(this->m_handlerFactory.getLoginManager(), this->m_handlerFactory); // adding new client
		
		thread clientThread(&Communicator::handleNewClient, this, client_socket);
		clientThread.detach();
	}
}


map<SOCKET, IRequestHandler*>& Communicator::getClients()
{
	return this->m_clients;
}


void Communicator::handleNewClient(const SOCKET socket)
{
	while (true)
	{
		try
		{
			int code = this->getCode(socket); // get code of data
			int length = this->getLengthOfData(socket); // get legnth of data
			vector<unsigned char> data = this->getData(socket, length); // get data
			string data_s(data.begin(), data.end());

			if (code == CLIENT_EXIT)
			{
				if (data_s == "logout") // log's out the user (logout & exit)
				{
					this->printRequestType(code);
					RequestResult response = this->m_clients.find(socket)->second->handleRequest({ static_cast<RequestCode>(LOGOUT_REQUEST), std::time(nullptr), data }, socket);
				}

				closesocket(socket);
				this->m_clients.erase(socket); // remove unactive socket from the map

				cout << "[EXIT] Client closed socket!\n" << endl;
				return;
			}

			this->printRequestType(code); // print type of request to Console

			RequestInfo request = { static_cast<RequestCode>(code), std::time(nullptr), data }; // create request info

			if (this->m_clients.find(socket)->second == nullptr)
			{
				cout << "[ERROR] Couldn't find socket" << endl;
			}
			
			if (this->m_clients.find(socket)->second != nullptr && this->m_clients.find(socket)->second->isRequestRelevant(request))
			{
				RequestResult response = this->m_clients.find(socket)->second->handleRequest(request, socket);

				if (response.newHandler != nullptr) // update the handler only if not NULL
				{
					this->m_clients.find(socket)->second = response.newHandler;
					//current_handler = this->m_clients.find(socket)->second;
					
				}

				string response_s(response.response.begin(), response.response.end());
				if (response_s != "")
				{
					Helper::sendData(socket, response_s); // send response
					cout << "[INFO] Sended response!\n" << endl;
				}
			}
			else // not a valid request
			{
				ErrorResponse response = { "Invalid request type!" };
				vector<char> error_response = JsonResponsePacketSerializer::serializeResponse(response);
				string error_response_s(error_response.begin(), error_response.end());
				Helper::sendData(socket, error_response_s); // send response
			}
		}

		catch (const std::exception& e)
		{
			cout << "[ERROR] Couldn't send message!\n" << endl;
			break;
		}
	}

	closesocket(socket);
}


void Communicator::bindAndListen(const int port)
{

	struct sockaddr_in sa = { 0 };
	sa.sin_port = htons(PORT);
	sa.sin_family = AF_INET;
	sa.sin_addr.s_addr = 0;

	if (::bind(m_serverSocket, (struct sockaddr*)&sa, sizeof(sa)) == SOCKET_ERROR)
		throw exception(__FUNCTION__ " - bind");
	cout << "[INFO] Binded on port: " << PORT << endl;

	if (::listen(m_serverSocket, SOMAXCONN) == SOCKET_ERROR)
		throw exception(__FUNCTION__ " - listen");
	cout << "[INFO] Listening..." << endl;
}


int Communicator::getCode(const SOCKET socket) const
{
	char code_buffer[CODE_BUFFER_SIZE]{};
	recv(socket, (char*)&code_buffer, CODE_BUFFER_SIZE, 0);
	unsigned int code = std::stoul(code_buffer, nullptr, MESSAGE_BASE);

	return code;
}


int Communicator::getLengthOfData(const SOCKET socket) const
{
	char length_buffer[LENGTH_BUFFER_SIZE]{};
	recv(socket, (char*)&length_buffer, LENGTH_BUFFER_SIZE, 0);
	unsigned int length = std::stoul(length_buffer, nullptr, MESSAGE_BASE);

	return length;
}


vector<unsigned char> Communicator::getData(const SOCKET socket, const int length) const
{
	char* data_buffer = new char[length + 1]; // plus 1 to include '\0'

	const int bytes_per_packet = 2;
	for (int i = 0; i < length; i = i + bytes_per_packet)
	{
		recv(socket, data_buffer + i, bytes_per_packet, 0); // get next bytes - data
	}

	data_buffer[length] = '\0';

	vector<unsigned char> data(data_buffer, data_buffer + length);
	delete[] data_buffer;
	return data;
}


void Communicator::printRequestType(const int code) const
{
	if (code == LOGIN_REQUEST)
	{
		cout << "[INFO] Got Login request!\n" << endl;
	}

	else if (code == SIGNUP_REQUEST)
		cout << "[INFO] Got Signup request!\n" << endl;

	else if (code == CREATE_ROOM_REQUEST)
		cout << "[INFO] Got Create Room request!\n" << endl;

	else if (code == GET_ROOMS_REQUEST)
		cout << "[INFO] Got Get Rooms request!\n" << endl;

	else if (code == GET_PLAYERS_IN_ROOM_REQUEST)
		cout << "[INFO] Got Get Players In Room request!\n" << endl;

	else if (code == JOIN_ROOM_REQUEST)
		cout << "[INFO] Got Join Room request!\n" << endl;

	else if (code == GET_PERSONAL_STATISTICS_REQUEST)
		cout << "[INFO] Got Get Statistics request!\n" << endl;

	else if (code == GET_HIGH_SCORE_REQUEST)
		cout << "[INFO] Got get high score request!\n" << endl;

	else if (code == LOGOUT_REQUEST)
		cout << "[INFO] Got Logout request!\n" << endl;
	
	else if (code == CLOSE_ROOM_REQUEST)
		cout << "[INFO] Got close room request!\n" << endl;

	else if (code == START_GAME_REQUEST)
		cout << "[INFO] Got start game request!\n" << endl;

	else if (code == GET_ROOM_STATE_REQUEST)
		cout << "[INFO] Got get room state request!\n" << endl;

	else if (code == LEAVE_ROOM_REQEUST)
		cout << "[INFO] Got leave room request!\n" << endl;

	else if (code == LEAVE_GAME_REQUEST)
		cout << "[INFO] Got leave game request!\n" << endl;

	else if (code == GET_QUESTION_REQUEST)
		cout << "[INFO] Got get question request!\n" << endl;

	else if (code == SUBMIT_ANSWER_REQUEST)
		cout << "[INFO] Got submit answer request!\n" << endl;

	else if (code == GET_GAME_RESULT_REQUEST)
		cout << "[INFO] Got get game result request!\n" << endl;

	else if (code == CLIENT_EXIT)
		cout << "[INFO] Got client exit request!\n" << endl;
}