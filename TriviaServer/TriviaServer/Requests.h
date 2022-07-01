#pragma once
#include <iostream>
#include <string>
#include <vector>
#include <ctime>

using std::cout;
using std::endl;
using std::string;
using std::vector;


class IRequestHandler;

typedef enum RequestCode
{
	LOGIN_REQUEST = 102,
	SIGNUP_REQUEST = 103,
	CREATE_ROOM_REQUEST = 104,
	GET_ROOMS_REQUEST = 105,
	GET_PLAYERS_IN_ROOM_REQUEST = 106,
	JOIN_ROOM_REQUEST = 107,
	GET_PERSONAL_STATISTICS_REQUEST = 108,
	GET_HIGH_SCORE_REQUEST = 109,
	LOGOUT_REQUEST = 110,
	CLOSE_ROOM_REQUEST = 111,
	START_GAME_REQUEST = 112,
	GET_ROOM_STATE_REQUEST = 113,
	LEAVE_ROOM_REQEUST = 114,
	LEAVE_GAME_REQUEST = 115,
	GET_QUESTION_REQUEST = 116,
	SUBMIT_ANSWER_REQUEST = 117,
	GET_GAME_RESULT_REQUEST = 118,
	ADD_QUESTION_REQUEST = 119,
	CLIENT_EXIT = 199
} RequestCode;


typedef struct LoginRequest
{
	string username;
	string password;

	void print() const
	{
		cout << "LoginRequest - \nusername: " + username + "\npassword: " + password << endl;
	}

} LoginRequest;


typedef struct SignupRequest
{
	string username;
	string password;
	string email;
	string address;
	string phoneNumber;
	string birthDate;

	void print() const
	{
		cout << "SignupRequest - \nusername: " + username + "\npassword: " + password + "\nemail: " + email + 
			"\naddress: " + address + "\nphone number: " + phoneNumber + "\nbirth date:" + birthDate << endl;
	}
} SignupRequest;


typedef struct GetPlayersInRoomRequest
{
	unsigned int roomId;

	void print() const
	{
		cout << "GetPlayersInRoomRequest - \roomId: " + roomId << endl;
	}
} GetPlayersInRoomRequest;


typedef struct JoinRoomRequest
{
	unsigned int roomId;

	void print() const
	{
		cout << "JoinRoomRequest - \roomId: " + roomId << endl;
	}
} JoinRoomRequest;


typedef struct CreateRoomRequest
{
	string roomName;
	unsigned int maxUsers;
	unsigned int questionCount;
	unsigned int answerTimeout;



	void print() const
	{
		cout << "CreateRoomRequest - \nroomName: " + roomName + "\nmaxUsers: " + std::to_string(maxUsers) + "\nquestionCount: " + std::to_string(questionCount) +
			"\nanswerTimeout: " + std::to_string(answerTimeout) << endl;
	}
} CreateRoomRequest;


typedef struct SubmitAnswerRequest
{
	unsigned int answerId;

	void print() const
	{
		cout << "SubmitAnswerRequest - \nanswerId: " + answerId << endl;
	}
} SubmitAnswerRequest;


typedef struct AddQuestionRequest
{
	string question;
	string c_answer1;
	string w_answer2;
	string w_answer3;
	string w_answer4;

	void print() const
	{
		cout << "AddQuestionRequest - \nquestion: " + question + "\nc_answer1: " + c_answer1 + "\nw_answer2: " + w_answer2 +
			"\nw_answer3: " + w_answer3 + "\nw_answer4: " + w_answer4 << endl;
	}
} AddQuestionRequest;


typedef struct RequestInfo 
{
	RequestCode id;
	time_t receivalTime;
	vector<unsigned char> buffer;
} RequestInfo;


typedef struct RequestResult 
{
	vector<char> response;
	IRequestHandler* newHandler;
} RequestResult;