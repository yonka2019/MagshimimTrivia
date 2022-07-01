#include "Server.h"

Server::Server(IDatabase* db)
{
	this->m_database = db;
}


void Server::run() const
{
	string input = "";

	RequestHandlerFactory& handler = RequestHandlerFactory::getInstance(this->m_database);
	Communicator& communicator = Communicator::getInstance(handler);
	thread t_connector(&Communicator::startHandleRequests, &communicator);

	std::cout << "[INFO] Accepting client..." << std::endl;
	t_connector.detach();

	while (true)
	{
		cin >> input;

		if (input == "EXIT")
			break;
	}
}