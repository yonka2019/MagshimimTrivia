#include "LoginManager.h"

vector<LoggedUser> LoginManager::m_loggedUsers = {};

LoginManager::LoginManager(IDatabase* db)
{
	this->m_database = db;
}


LoginManager::~LoginManager()
{
	this->m_database = nullptr;
}


void LoginManager::login(const string username, const string password, const SOCKET socket)
{
	// check if user already logged in

	this->users_mtx.lock(); // make sure we read all the users properly
	for (auto& user : this->m_loggedUsers) 
	{
		if (username == user.getUsername())
		{
			this->users_mtx.unlock();
			throw exception("[ERROR] User is already logged in");
		}
	}
	this->users_mtx.unlock();

	// checks users password (if matches according his record in the db)
	if (this->m_database->doesPasswordMatch(username, password))
		this->m_loggedUsers.push_back(LoggedUser(username, socket));
	else
		throw exception("[ERROR] Invalid password or username");
}


void LoginManager::signup(const string username, const string password, const string email, const string address, const string phoneNumber, const string birthDate)
{
	vector<pair<string, pair<regex, string>>> all_checks; // all the checks to do on the infromation
	
	all_checks.push_back({ password, {(regex)(REGEX_PASSWORD), "[ERROR] Password should be 8+ length, contain uppercase, lowercase and special characters, digits"} }); // check for password
	all_checks.push_back({ email, {(regex)(REGEX_EMAIL), "[ERROR] email should be separated via @ and should contain . (dot) between the email and the domain" } }); // check for email
	all_checks.push_back({ address, {(regex)(REGEX_ADDRESS), "[ERROR] Address should be (Street [upper/lower case characters], Apt [digits], City [upper/lower case characters])" } }); // check for address
	all_checks.push_back({ phoneNumber, {(regex)(REGEX_PHONE_NUMBER), "[ERROR] Number should begin with 0 and continue with 1-2 numbers (0X/05X)" } }); // check for phoneNumber
	all_checks.push_back({ birthDate, { (regex)(REGEX_BIRTH_DATE), "[ERROR] Birth date should be DD.MM.YYYY or DD/MM/YYYY" } }); // check for birthDate


	for (auto i : all_checks) // loop through all the checks
	{
		if (!regex_search(i.first, i.second.first)) // check if current info is valid
		{
			throw exception(i.second.second.c_str());
		}
	}

	if (this->m_database->doesUserExist(username)) // check if user already exists in the data base
		throw exception("[ERROR] User with this name already exists");

	else // everything is valid -> add the user
	{
		this->users_mtx.lock();
		this->m_database->addNewUser(username, password, email, address, phoneNumber, birthDate);
		this->users_mtx.unlock();
	}
}


void LoginManager::logout(const string username)
{
	bool loggedIn = false;
	auto it = this->m_loggedUsers.begin();

	this->users_mtx.lock();
	while (it != this->m_loggedUsers.end() && !loggedIn) // search the user in the vector of users
	{
		if (it->getUsername() == username)
			loggedIn = true;
		else
			it++;
	}

	if (loggedIn)
	{
		this->m_loggedUsers.erase(it); // remove the user from the vector of users
		this->users_mtx.unlock();
	}
		
	else
	{
		this->users_mtx.unlock();
		throw exception("[ERROR] This username isn't logged in");
	}
}
