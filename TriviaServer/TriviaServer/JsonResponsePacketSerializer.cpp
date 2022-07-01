#include "JsonResponsePacketSerializer.h"

vector<char> JsonResponsePacketSerializer::serializeResponse(const ErrorResponse response)
{
	json serializedData = { {"message", response.message} };
	return createResponsePacket(ERROR_RESPONSE, serializedData.dump());
}


vector<char> JsonResponsePacketSerializer::serializeResponse(const LoginResponse response)
{
	json serializedData = { {"status", response.status} };
	return createResponsePacket(response.status, serializedData.dump());
}


vector<char> JsonResponsePacketSerializer::serializeResponse(const SignupResponse response) 
{
	json serializedData = { {"status", response.status} };
	return createResponsePacket(response.status, serializedData.dump());
}


vector<char> JsonResponsePacketSerializer::serializeResponse(const LogoutResponse response)
{
	json serializedData = { {"status", response.status} };
	return createResponsePacket(response.status, serializedData.dump());
}


vector<char> JsonResponsePacketSerializer::serializeResponse(const GetRoomsResponse response)
{
	json serializedData = { {"status", response.status}, {"Rooms", {}} };

	for (auto& room : response.rooms)
	{
		serializedData["Rooms"].push_back({
			{"id", room.id},
			{"name", room.name},
			{"maxPlayers", room.maxPlayers},
			{"numOfQuestionsInGame", room.numOfQuestionsInGame},
			{"timePerQuestion", room.timePerQuestion},
			{"isActive", room.isActive},

			});
	}

	return createResponsePacket(response.status, serializedData.dump());
}


vector<char> JsonResponsePacketSerializer::serializeResponse(const GetPlayersInRoomResponse response)
{
	json serializedData = { {"PlayersInRoom", response.players} };

	return createResponsePacket(GET_PLAYERS_RESPONSE, serializedData.dump());
}


vector<char> JsonResponsePacketSerializer::serializeResponse(const JoinRoomResponse response)
{
	json serializedData = { {"status", response.status} };
	return createResponsePacket(response.status, serializedData.dump());
}


vector<char> JsonResponsePacketSerializer::serializeResponse(const CreateRoomResponse response)
{
	json serializedData = { {"status", response.status} };
	return createResponsePacket(response.status, serializedData.dump());
}


vector<char> JsonResponsePacketSerializer::serializeResponse(const GetPersonalStatsResponse response)
{
	std::ostringstream averageAnswerTime;
	double avgAnswerTime = std::stod(response.statistics[AVG_TIME_INDEX]);
	averageAnswerTime << std::fixed << std::setprecision(DIGITS_AFTER_DOT) << avgAnswerTime << "s";

	json serializedData = { {"status", response.status}, {"UserStatistics", {}} };

	serializedData["UserStatistics"].push_back(response.statistics[C_ANSWER_INDEX]); // right answers
	serializedData["UserStatistics"].push_back(response.statistics[W_ANSWER_INDEX]); // wrong answers
	serializedData["UserStatistics"].push_back(averageAnswerTime.str()); // average answer time

	return createResponsePacket(response.status, serializedData.dump());
}


vector<char> JsonResponsePacketSerializer::serializeResponse(const GetHighScoreResponse response)
{
	json serializedData = { {"status", response.status}, {"HighScores", {}}};

	for (auto& statistics : response.statistics)
	{
		serializedData["HighScores"].push_back({ {"username", statistics.username}, {"score", statistics.score}});
	}

	return createResponsePacket(response.status, serializedData.dump());
}


vector<char> JsonResponsePacketSerializer::serializeResponse(const CloseRoomResponse response)
{
	json serializedData = { {"status", response.status} };
	return createResponsePacket(response.status, serializedData.dump());
}


vector<char> JsonResponsePacketSerializer::serializeResponse(const StartGameResponse response)
{
	json serializedData = { {"status", response.status} };
	return createResponsePacket(response.status, serializedData.dump());
}


vector<char> JsonResponsePacketSerializer::serializeResponse(const GetRoomStateResponse response)
{
	json serializedData = { {"status", response.status}, {"hasGameBegun", response.hasGameBegun}, {"players", response.players}, {"questionCount", response.questionCount}, {"answerTimeout", response.answerTimeout}, {"maxPlayers", response.maxPlayers} };
	return createResponsePacket(response.status, serializedData.dump());
}


vector<char> JsonResponsePacketSerializer::serializeResponse(const LeaveRoomResponse response)
{
	json serializedData = { {"status", response.status} };
	return createResponsePacket(response.status, serializedData.dump());
}


vector<char> JsonResponsePacketSerializer::serializeResponse(const LeaveGameResponse response)
{
	json serializedData = { {"status", response.status} };
	return createResponsePacket(LEAVE_GAME_RESPONSE, serializedData.dump());
}


vector<char> JsonResponsePacketSerializer::serializeResponse(const SubmitAnswerResponse response)
{
	json serializedData = { {"status", response.status}, {"correctAnswerId", response.correctAnswerId} };
	return createResponsePacket(SUBMIT_ANSWER_RESPONSE, serializedData.dump());
}


vector<char> JsonResponsePacketSerializer::serializeResponse(const GetQuestionResponse response)
{
	json serializedData = { {"status", response.status}, {"question", response.question}, {"answers", response.answers} };
	return createResponsePacket(GET_QUESTION_RESPONSE, serializedData.dump());
}


vector<char> JsonResponsePacketSerializer::serializeResponse(const GetGameResultsResponse response)
{
	json serializedData = { {"status", response.status}, {"Results", {}} };

	for (auto& result : response.results)
	{
		serializedData["Results"].push_back({
			{"username", result.username},
			{"correctAnswerCount", result.correctAnswerCount},
			{"wrongAnswerCount", result.wrongAnswerCount},
			{"averageAnswerTime", result.averageAnswerTime},
			{"score", result.score}
			});
	}

	return createResponsePacket(GET_GAME_RESULT_RESPONSE, serializedData.dump());
}


vector<char> JsonResponsePacketSerializer::serializeResponse(const AddQuestionResponse response)
{
	json serializedData = { {"status", response.status} };
	return createResponsePacket(ADD_QUESTION_RESPONSE, serializedData.dump());
}


vector<char> JsonResponsePacketSerializer::createResponsePacket(const int response_code, const string serializedData)
{
	vector<char> response_packet_bytes;
	response_packet_bytes.push_back(static_cast<unsigned char>(response_code)); // add code

	vector<char> bytes_of_data_len = convertIntToBytes(serializedData.size()); // convert length to bytes
	std::copy(bytes_of_data_len.begin(), bytes_of_data_len.end(), std::back_inserter(response_packet_bytes)); // add length
	std::copy(serializedData.begin(), serializedData.end(), std::back_inserter(response_packet_bytes)); // add data

	return response_packet_bytes;
}


vector<char> JsonResponsePacketSerializer::convertIntToBytes(const int num)
{	
	vector<char> arrayOfByte(CODE_LENGTH_SIZE);

	for (int i = 0; i < CODE_LENGTH_SIZE; i++) // going over all the bytes
		arrayOfByte[CODE_LENGTH_SIZE - 1 - i] = (num >> (i * SHIFT_BY)); // shifting the bytes
	return arrayOfByte;
}