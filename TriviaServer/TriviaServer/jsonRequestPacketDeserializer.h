#pragma once

#include "Requests.h"
#include <iostream>
#include <vector>
#include <string>
#include "json.hpp"

using std::cout;
using std::endl;

using std::vector;
using std::string;
using json = nlohmann::json;

class JsonRequestPacketDeserializer
{
public:
	static JsonRequestPacketDeserializer& getInstance()
	{
		static JsonRequestPacketDeserializer instance;
		return instance;
	}
	// delete copy constructor and assignment operator for singleton
	JsonRequestPacketDeserializer(JsonRequestPacketDeserializer const&) = delete;
	void operator=(JsonRequestPacketDeserializer const&) = delete;
	
	/// <summary>
	/// The function deserializes the given buffer - turns it into a "LoginRequest" object
	/// </summary>
	/// <param name="buffer">Buffer that represents the whole request</param>
	/// <returns>A "LoginRequest" object</returns>
	static LoginRequest deserializeLoginRequest(const vector<unsigned char> buffer);

	/// <summary>
	/// The function deserializes the given buffer - turns it into a "SignupRequest" object
	/// </summary>
	/// <param name="buffer">Buffer that represents the whole request</param>
	/// <returns>A "SignupRequest" object</returns>
	static SignupRequest deserializeSignupRequest(const vector<unsigned char> buffer);
	
	/// <summary>
	/// The function deserializes the given buffer - turns it into a "GetPlayersInRoomRequest" object
	/// </summary>
	/// <param name="buffer">Buffer that represents the whole request</param>
	/// <returns>A "GetPlayersInRoomRequest" object</returns>
	static GetPlayersInRoomRequest desirializeGetPlayersRequest(const vector<unsigned char> buffer);

	/// <summary>
	/// The function deserializes the given buffer - turns it into a "JoinRoomRequest" object
	/// </summary>
	/// <param name="buffer">Buffer that represents the whole request</param>
	/// <returns>A "JoinRoomRequest" object</returns>
	static JoinRoomRequest desirializeJoinRoomRequest(const vector<unsigned char> buffer);

	/// <summary>
	/// The function deserializes the given buffer - turns it into a "CreateRoomRequest" object
	/// </summary>
	/// <param name="buffer">Buffer that represents the whole request</param>
	/// <returns>A "CreateRoomRequest" object</returns>
	static CreateRoomRequest desirializeCreateRoomRequest(const vector<unsigned char> buffer);

	/// <summary>
	/// The function deserializes the given buffer - turns it into a "SubmitAnswerRequest" object
	/// </summary>
	/// <param name="buffer">Buffer that represents the whole request</param>
	/// <returns>A "SubmitAnswerRequest" object</returns>
	static SubmitAnswerRequest deserializerSubmitAnswerRequest(const vector<unsigned char> buffer);

	/// <summary>
	/// The function deserializes the given buffer - turns it into a "AddQuestionRequest" object
	/// </summary>
	/// <param name="buffer">Buffer that represents the whole request</param>
	/// <returns>A "AddQuestionRequest" object</returns>
	static AddQuestionRequest deserializerAddQuestionRequest(const vector<unsigned char> buffer);


private:
	JsonRequestPacketDeserializer() {}
};

