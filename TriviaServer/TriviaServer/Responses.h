#pragma once
#include <iostream>
#include <string>
#include <vector>
#include <map>
#include "Room.h"

using std::cout;
using std::endl;
using std::string;
using std::vector;
using std::map;



typedef enum ResponseCode
{
	ERROR_RESPONSE = 101,
	LOGIN_RESPONSE = 102,
	SIGNUP_RESPONSE = 103,
	LOGOUT_RESPONSE = 104,
	GET_ROOMS_RESPONSE = 105,
	GET_PLAYERS_RESPONSE = 106,
	GET_HIGHSCORE_RESPONSE = 107,
	GET_PERSONAL_STATS_RESPONSE = 108,
	JOIN_ROOM_RESPONSE = 109,
	CREATE_ROOM_RESPONSE = 110,
	CLOSE_ROOM_RESPONSE = 111,
	START_GAME_RESPONSE = 112,
	GET_ROOM_RESPONSE = 113,
	LEAVE_ROOM_RESPONSE = 114,
	LEAVE_GAME_RESPONSE = 115,
	GET_QUESTION_RESPONSE = 116,
	SUBMIT_ANSWER_RESPONSE = 117,
	GET_GAME_RESULT_RESPONSE = 118,
	ADD_QUESTION_RESPONSE = 119,
	SUCCESS_RESPONSE = 1,
	FAIL_RESPONSE = 0
} ResponseCode;

typedef struct Highscore // struct to organize the Highscore table
{
	string username;
	double score;
} Highscore;

typedef struct LoginResponse 
{
	unsigned int status;

	void print() const
	{
		cout << "LoginResponse -\nstatus: " + status << endl;
	}
} LoginResponse;


typedef struct SignupResponse 
{
	unsigned int status;

	void print() const
	{
		cout << "SignupResponse -\nstatus: " + status << endl;
	}
} SignupResponse;


typedef struct LogoutResponse
{
	unsigned int status;

	void print() const
	{
		cout << "LogoutResponse -\nstatus: " + status << endl;
	}
} LogoutResponse;


typedef struct GetRoomsResponse 
{
	unsigned int status;
	vector<RoomData> rooms;

	void print() const
	{
		cout << "GetRoomsResponse -\nstatus: " + status << endl;
	}
} GetRoomsResponse;


typedef struct GetPlayersInRoomResponse
{
	unsigned int status;
	vector<string> players;

	void print() const
	{
		cout << "GetPlayersInRoomResponse -\nstatus: " + status << endl;
	}
} GetPlayersInRoomResponse;


typedef struct GetHighScoreResponse
{
	unsigned int status;
	vector<Highscore> statistics;

	void print() const
	{
		cout << "GetHighScoreResponse -\nstatus: " + status << endl;
	}
} GetHighScoreResponse;


typedef struct GetPersonalStatsResponse
{
	unsigned int status;
	vector<string> statistics;

	void print() const
	{
		cout << "GetPersonalStatsResponse -\nstatus: " + status << endl;
	}
} GetPersonalStatsResponse;


typedef struct JoinRoomResponse
{
	unsigned int status;

	void print() const
	{
		cout << "JoinRoomResponse -\nstatus: " + status << endl;
	}
} JoinRoomResponse;


typedef struct CreateRoomResponse
{
	unsigned int status;

	void print() const
	{
		cout << "CreateRoomResponse -\nstatus: " + status << endl;
	}
} CreateRoomResponse;


typedef struct CloseRoomResponse
{
	unsigned int status;

	void print() const
	{
		cout << "CloseRoomResponse -\nstatus: " + status << endl;
	}
} CloseRoomResponse;


typedef struct StartGameResponse
{
	unsigned int status;

	void print() const
	{
		cout << "StartGameResponse -\nstatus: " + status << endl;
	}
} StartGameResponse;


typedef struct GetRoomStateResponse
{
	unsigned int status;
	bool hasGameBegun;
	vector<string> players;
	unsigned int questionCount;
	unsigned int answerTimeout;
	unsigned int maxPlayers;

	void print() const
	{
		cout << "GetRoomStateResponse -\nstatus: " + status << endl;
	}
} GetRoomStateResponse;


typedef struct LeaveRoomResponse
{
	unsigned int status;

	void print() const
	{
		cout << "LeaveRoomResponse -\nstatus: " + status << endl;
	}
} LeaveRoomResponse;


typedef struct LeaveGameResponse
{
	unsigned int status;

	void print() const
	{
		cout << "LeaveGameResponse -\nstatus: " + status << endl;
	}
} LeaveGameResponse;


typedef struct GetQuestionResponse
{
	unsigned int status;
	string question;
	map<unsigned int, string> answers;

	void print() const
	{
		cout << "GetQuestionResponse -\nstatus: " + status << endl;
	}
} GetQuestionResponse;


typedef struct SubmitAnswerResponse
{
	unsigned int status;
	unsigned int correctAnswerId;

	void print() const
	{
		cout << "SubmitAnswerResponse -\nstatus: " + status << endl;
	}
} SubmitAnswerResponse;


typedef struct PlayerResults
{
	string username;
	unsigned int correctAnswerCount;
	unsigned int wrongAnswerCount;
	double averageAnswerTime;
	double score;

	void print() const
	{
		cout << "PlayerResults -\nusername: " + username << endl;
	}
} PlayerResults;


typedef struct GetGameResultsResponse
{
	unsigned int status;
	vector<PlayerResults> results;

	void print() const
	{
		cout << "GetGameResultsResponse -\nstatus: " + status << endl;
	}
} GetGameResultsResponse;


typedef struct AddQuestionResponse
{
	unsigned int status;

	void print() const
	{
		cout << "AddQuestionResponse -\nstatus: " + status << endl;
	}
} AddQuestionResponse;


typedef struct ErrorResponse
{
	string message;

	void print() const
	{
		cout << "ErrorResponse -\nmessage: " + message << endl;
	}
} ErrorResponse;
