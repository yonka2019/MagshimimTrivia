#include "jsonRequestPacketDeserializer.h"

LoginRequest JsonRequestPacketDeserializer::deserializeLoginRequest(const vector<unsigned char> buffer)
{
	string data(buffer.begin(), buffer.end());
	data = data.substr(data.find('{')); // get only the json part

	json jsonData = json::parse(data); // parse to json
	return LoginRequest({ jsonData["username"], jsonData["password"] });
}


SignupRequest JsonRequestPacketDeserializer::deserializeSignupRequest(const vector<unsigned char> buffer)
{
	string data(buffer.begin(), buffer.end());
	data = data.substr(data.find('{'));// get only the json part

	json jsonData = json::parse(data); // parse to json
	return SignupRequest({ jsonData["username"], jsonData["password"], jsonData["email"],
		jsonData["address"], jsonData["phoneNumber"], jsonData["birthDate"]});
}


GetPlayersInRoomRequest JsonRequestPacketDeserializer::desirializeGetPlayersRequest(const vector<unsigned char> buffer)
{
	string data(buffer.begin(), buffer.end());
	data = data.substr(data.find('{'));// get only the json part

	json jsonData = json::parse(data); // parse to json
	return GetPlayersInRoomRequest({ jsonData["roomId"]});
}


JoinRoomRequest JsonRequestPacketDeserializer::desirializeJoinRoomRequest(const vector<unsigned char> buffer)
{
	string data(buffer.begin(), buffer.end());
	data = data.substr(data.find('{'));// get only the json part

	json jsonData = json::parse(data); // parse to json
	return JoinRoomRequest({ jsonData["roomId"] });
}


CreateRoomRequest JsonRequestPacketDeserializer::desirializeCreateRoomRequest(const vector<unsigned char> buffer)
{
	string data(buffer.begin(), buffer.end());
	data = data.substr(data.find('{'));// get only the json part

	json jsonData = json::parse(data); // parse to json
	return CreateRoomRequest({ jsonData["roomName"], jsonData["maxUsers"], jsonData["questionCount"], jsonData["answerTimeout"] });
}


SubmitAnswerRequest JsonRequestPacketDeserializer::deserializerSubmitAnswerRequest(const vector<unsigned char> buffer)
{
	string data(buffer.begin(), buffer.end());
	data = data.substr(data.find('{'));// get only the json part

	json jsonData = json::parse(data); // parse to json
	return SubmitAnswerRequest({ jsonData["answerId"] });
}


AddQuestionRequest JsonRequestPacketDeserializer::deserializerAddQuestionRequest(const vector<unsigned char> buffer)
{
	string data(buffer.begin(), buffer.end());
	data = data.substr(data.find('{'));// get only the json part

	json jsonData = json::parse(data); // parse to json

	return AddQuestionRequest({ jsonData["question"], jsonData["c_answer1"], jsonData["w_answer2"], jsonData["w_answer3"], jsonData["w_answer4"] });
}
