#pragma once

#include "Responses.h"
#include <iostream>
#include <vector>
#include <string>
#include "json.hpp"
#include <sstream>
#include <iomanip>

using std::cout;
using std::endl;

using std::vector;
using std::string;
using json = nlohmann::json;

#define CODE_LENGTH_SIZE 4
#define SHIFT_BY 8
#define DIGITS_AFTER_DOT 2
#define C_ANSWER_INDEX 0
#define W_ANSWER_INDEX 1
#define AVG_TIME_INDEX 2

class JsonResponsePacketSerializer
{

public:
	static JsonResponsePacketSerializer& getInstance()
	{
		static JsonResponsePacketSerializer instance;
		return instance;
	}
	// delete copy constructor and assignment operator for singleton
	JsonResponsePacketSerializer(JsonResponsePacketSerializer const&) = delete;
	void operator=(JsonResponsePacketSerializer const&) = delete;

	/// <summary>
	/// The function serializes the response - "ErrorResponse" object into a buffer (vector of char)
	/// </summary>
	/// <param name="response">ErrorResponse object</param>
	/// <returns>Buffer (vector of char)</returns>
	static vector<char> serializeResponse(const ErrorResponse response);

	/// <summary>
	/// The function serializes the response - "LoginResponse" object into a buffer (vector of char)
	/// </summary>
	/// <param name="response">LoginResponse object</param>
	/// <returns>Buffer (vector of char)</returns>
	static vector<char> serializeResponse(const LoginResponse response);

	/// <summary>
	/// The function serializes the response - "SignupResponse" object into a buffer (vector of char)
	/// </summary>
	/// <param name="response">SignupResponse object</param>
	/// <returns>Buffer (vector of char)</returns>
	static vector<char> serializeResponse(const SignupResponse response);

	// <summary>
	/// The function serializes the response - "LogoutResponse" object into a buffer (vector of char)
	/// </summary>
	/// <param name="response">LogoutResponse object</param>
	/// <returns>Buffer (vector of char)</returns>
	static vector<char> serializeResponse(const LogoutResponse response);

	// <summary>
	/// The function serializes the response - "GetRoomsResponse" object into a buffer (vector of char)
	/// </summary>
	/// <param name="response">GetRoomsResponse object</param>
	/// <returns>Buffer (vector of char)</returns>
	static vector<char> serializeResponse(const GetRoomsResponse response);

	// <summary>
	/// The function serializes the response - "GetPlayersInRoomResponse" object into a buffer (vector of char)
	/// </summary>
	/// <param name="response">GetPlayersInRoomResponse object</param>
	/// <returns>Buffer (vector of char)</returns>
	static vector<char> serializeResponse(const GetPlayersInRoomResponse response);

	// <summary>
	/// The function serializes the response - "JoinRoomResponse" object into a buffer (vector of char)
	/// </summary>
	/// <param name="response">JoinRoomResponse object</param>
	/// <returns>Buffer (vector of char)</returns>
	static vector<char> serializeResponse(const JoinRoomResponse response);

	// <summary>
	/// The function serializes the response - "CreateRoomResponse" object into a buffer (vector of char)
	/// </summary>
	/// <param name="response">CreateRoomResponse object</param>
	/// <returns>Buffer (vector of char)</returns>
	static vector<char> serializeResponse(const CreateRoomResponse response);

	// <summary>
	/// The function serializes the response - "GetPersonalStatsResponse" object into a buffer (vector of char)
	/// </summary>
	/// <param name="response">GetPersonalStatsResponse object</param>
	/// <returns>Buffer (vector of char)</returns>
	static vector<char> serializeResponse(const GetPersonalStatsResponse response);

	// <summary>
	/// The function serializes the response - "GetHighScoreResponse" object into a buffer (vector of char)
	/// </summary>
	/// <param name="response">GetHighScoreResponse object</param>
	/// <returns>Buffer (vector of char)</returns>
	static vector<char> serializeResponse(const GetHighScoreResponse response);

	// <summary>
	/// The function serializes the response - "CloseRoomResponse" object into a buffer (vector of char)
	/// </summary>
	/// <param name="response">CloseRoomResponse object</param>
	/// <returns>Buffer (vector of char)</returns>
	static vector<char> serializeResponse(const CloseRoomResponse response);

	// <summary>
	/// The function serializes the response - "StartGameResponse" object into a buffer (vector of char)
	/// </summary>
	/// <param name="response">StartGameResponse object</param>
	/// <returns>Buffer (vector of char)</returns>
	static vector<char> serializeResponse(const StartGameResponse response);

	// <summary>
	/// The function serializes the response - "GetRoomStateResponse" object into a buffer (vector of char)
	/// </summary>
	/// <param name="response">GetRoomStateResponse object</param>
	/// <returns>Buffer (vector of char)</returns>
	static vector<char> serializeResponse(const GetRoomStateResponse response);

	// <summary>
	/// The function serializes the response - "LeaveRoomResponse" object into a buffer (vector of char)
	/// </summary>
	/// <param name="response">LeaveRoomResponse object</param>
	/// <returns>Buffer (vector of char)</returns>
	static vector<char> serializeResponse(const LeaveRoomResponse response);

	// <summary>
	/// The function serializes the response - "LeaveGameResponse" object into a buffer (vector of char)
	/// </summary>
	/// <param name="response">LeaveGameResponse object</param>
	/// <returns>Buffer (vector of char)</returns>
	static vector<char> serializeResponse(const LeaveGameResponse response);

	// <summary>
	/// The function serializes the response - "SubmitAnswerResponse" object into a buffer (vector of char)
	/// </summary>
	/// <param name="response">SubmitAnswerResponse object</param>
	/// <returns>Buffer (vector of char)</returns>
	static vector<char> serializeResponse(const SubmitAnswerResponse response);

	// <summary>
	/// The function serializes the response - "GetQuestionResponse" object into a buffer (vector of char)
	/// </summary>
	/// <param name="response">GetQuestionResponse object</param>
	/// <returns>Buffer (vector of char)</returns>
	static vector<char> serializeResponse(const GetQuestionResponse response);

	// <summary>
	/// The function serializes the response - "GetGameResultsResponse" object into a buffer (vector of char)
	/// </summary>
	/// <param name="response">GetGameResultsResponse object</param>
	/// <returns>Buffer (vector of char)</returns>
	static vector<char> serializeResponse(const GetGameResultsResponse response);

	// <summary>
	/// The function serializes the response - "AddQuestionResponse" object into a buffer (vector of char)
	/// </summary>
	/// <param name="response">AddQuestionResponse object</param>
	/// <returns>Buffer (vector of char)</returns>
	static vector<char> serializeResponse(const AddQuestionResponse response);




	
private:
	JsonResponsePacketSerializer() {}
	/// <summary>
	/// The function creates the response packet with all the details (code, size, data)
	/// </summary>
	/// <param name="response_code">code of the respnose</param>
	/// <param name="serializedData">data to get the details about</param>
	/// <returns>Buffer (vector of char)</returns>
	static vector<char> createResponsePacket(const int response_code, const string serializedData);

	/// <summary>
	/// The function converts int into four bytes
	/// </summary>
	/// <param name="num">Number to convert</param>
	/// <returns>Buffer (vector of char)</returns>
	static vector<char> convertIntToBytes(const int num);
};
