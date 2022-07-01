using Newtonsoft.Json;
using System.Collections.Generic;

namespace TriviaClient
{
    public static class TriviaProtocol // Class which creates ready message
    {
        /// <summary>
        /// Formats the returned response into one informatically message without any payload
        /// </summary>
        /// <param name="recvMsg">received message from the server which needed to be formatted</param>
        /// <returns>Formatted message</returns>
        public static string FormatResponseByMessage(string recvMsg)
        {
            TriviaMessage message = new TriviaMessage(recvMsg);
            Dictionary<string, string> mDic = message.ToDict();

            return mDic.ContainsKey("message") ? mDic["message"] : "";
        }

        /// <summary>
        /// Builds up sign in message
        /// </summary>
        /// <returns>Ready message to be sent to the server</returns>
        public static string SignIn(string username, string password, string email, string address, string phoneNumber, string birthDate)
        {
            Dictionary<string, string> jsonDictionary = new Dictionary<string, string>
            {
                { "username", username },
                { "password", password },
                { "email", email },
                { "address", address },
                { "phoneNumber", phoneNumber },
                { "birthDate", birthDate }
            };

            TriviaMessage signUpMessage = new TriviaMessage
            {
                Code = (int)TriviaRequest.SIGN_UP,
                Content = JsonConvert.SerializeObject(jsonDictionary)
            };
            return signUpMessage.ToString();
        }

        /// <summary>
        /// Builds up login message
        /// </summary>
        /// <returns>Ready message to be sent to the server</returns>
        public static string Login(string username, string password)
        {
            Dictionary<string, string> jsonDictionary = new Dictionary<string, string>
            {
                { "username", username },
                { "password", password }
            };

            TriviaMessage loginMessage = new TriviaMessage
            {
                Code = (int)TriviaRequest.LOGIN,
                Content = JsonConvert.SerializeObject(jsonDictionary)
            };
            return loginMessage.ToString();
        }

        public static string Logout()
        {
            TriviaMessage logoutMessage = new TriviaMessage((int)TriviaRequest.EXIT_CLIENT, "");

            if (Socket.IsLogged) // if user logged in - log out
                logoutMessage.Content = "logout";

            return logoutMessage.ToString();
        }

        /// <summary>
        /// Builds up create room message
        /// </summary>
        /// <returns>Ready message to be sent to the server</returns>
        public static string CreateRoom(string roomName, int maxUsers, int questionCount, int answerTimeout)
        {
            Dictionary<string, object> jsonDictionary = new Dictionary<string, object>
            {
                { "roomName", roomName },
                { "maxUsers", maxUsers },
                { "questionCount", questionCount },
                { "answerTimeout", answerTimeout },
            };

            TriviaMessage createRoomMessage = new TriviaMessage
            {
                Code = (int)TriviaRequest.CREATE_ROOM,
                Content = JsonConvert.SerializeObject(jsonDictionary)
            };
            return createRoomMessage.ToString();
        }

        /// <summary>
        /// Builds up gets room message
        /// </summary>
        /// <returns>Ready message to be sent to the server</returns>
        public static string GetRooms()
        {
            TriviaMessage getRoomsMessage = new TriviaMessage((int)TriviaRequest.GET_ROOMS, "");
            return getRoomsMessage.ToString();
        }

        /// <summary>
        /// Builds up a get users in room message (called from menu handler)
        /// </summary>
        /// <returns>Ready message to be sent to the server</returns>
        public static string GetUsersInRoom(int roomId)
        {
            Dictionary<string, int> jsonDictionary = new Dictionary<string, int>
            {
                { "roomId", roomId }
            };

            TriviaMessage getUsersInRoomMessage = new TriviaMessage
            {
                Code = (int)TriviaRequest.GET_USERS_IN_ROOM,
                Content = JsonConvert.SerializeObject(jsonDictionary)
            };
            return getUsersInRoomMessage.ToString();
        }

        /// <summary>
        /// Builds up get room state (which contains current room data)
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentRoomState()
        {
            TriviaMessage getRoomStateMessage = new TriviaMessage((int)TriviaRequest.GET_ROOM_STATE, "");
            return getRoomStateMessage.ToString();
        }

        /// <summary>
        /// Builds up join room message
        /// </summary>
        /// <returns>Ready message to be sent to the server</returns>
        public static string JoinRoom(int roomId)
        {
            Dictionary<string, int> jsonDictionary = new Dictionary<string, int>
            {
                { "roomId", roomId }
            };

            TriviaMessage joinRoomMessage = new TriviaMessage
            {
                Code = (int)TriviaRequest.JOIN_ROOM,
                Content = JsonConvert.SerializeObject(jsonDictionary)
            };
            return joinRoomMessage.ToString();
        }

        /// <summary>
        /// Builds up get personal statistics message
        /// </summary>
        /// <returns>Ready message to be sent to the server</returns>
        public static string GetPersonalStatistics()
        {
            TriviaMessage getPesonalStatisticsMessage = new TriviaMessage((int)TriviaRequest.GET_PERSONAL_STATISTICS, "");
            return getPesonalStatisticsMessage.ToString();
        }

        /// <summary>
        /// Builds up get high score message
        /// </summary>
        /// <returns>Ready message to be sent to the server</returns>
        public static string GetHighScore()
        {
            TriviaMessage getHighScoreMessage = new TriviaMessage((int)TriviaRequest.GET_HIGH_SCORE_STATISTICS, "");
            return getHighScoreMessage.ToString();
        }

        /// <summary>
        /// Builds up leave room message
        /// </summary>
        /// <returns>Ready message to be sent to the server</returns>
        public static string LeaveRoom()
        {
            TriviaMessage leaveRoomMessage = new TriviaMessage((int)TriviaRequest.LEAVE_ROOM, "");
            return leaveRoomMessage.ToString();
        }

        /// <summary>
        /// Builds up close room message
        /// </summary>
        /// <returns>Ready message to be sent to the server</returns>
        public static string CloseRoom()
        {
            TriviaMessage closeRoomMessage = new TriviaMessage((int)TriviaRequest.CLOSE_ROOM, "");
            return closeRoomMessage.ToString();
        }

        /// <summary>
        /// Builds up a start game message
        /// </summary>
        /// <returns>Ready message to be sent to the server</returns>
        public static string StartGame()
        {
            TriviaMessage startGameMessage = new TriviaMessage((int)TriviaRequest.START_GAME, "");
            return startGameMessage.ToString();
        }

        /// <summary>
        /// Builds up a get question message
        /// </summary>
        /// <returns>Ready message to be sent to the server</returns>
        public static string GetQuestion()
        {
            TriviaMessage getQuestionMessage = new TriviaMessage((int)TriviaRequest.GET_QUESTION, "");
            return getQuestionMessage.ToString();
        }

        /// <summary>
        /// Builds up a sumbit answer message
        /// </summary>
        /// <returns>Ready message to be sent to the server</returns>
        public static string SubmitAnswer(int answerId)
        {
            Dictionary<string, int> jsonDictionary = new Dictionary<string, int>
            {
                { "answerId", answerId }
            };

            TriviaMessage sumbitAnsewrMessage = new TriviaMessage
            {
                Code = (int)TriviaRequest.SUBMIT_ANSWER,
                Content = JsonConvert.SerializeObject(jsonDictionary)
            };
            return sumbitAnsewrMessage.ToString();
        }

        /// <summary>
        /// Builds up a leave game message
        /// </summary>
        /// <returns>Ready message to be sent to the server</returns>
        public static string LeaveGame()
        {
            TriviaMessage leaveGameMessage = new TriviaMessage((int)TriviaRequest.LEAVE_GAME, "");
            return leaveGameMessage.ToString();
        }

        /// <summary>
        /// Builds up a get game results message
        /// </summary>
        /// <returns>Ready message to be sent to the server</returns>
        public static string GetGameResults()
        {
            TriviaMessage getGameResultsMessage = new TriviaMessage((int)TriviaRequest.GET_GAME_RESULT, "");
            return getGameResultsMessage.ToString();
        }

        /// <summary>
        /// Builds up a add question message
        /// </summary>
        /// <returns>Ready message to be sent to the server</returns>
        public static string AddQuestion(string question, string c_answer1, string w_answer2, string w_answer3, string w_answer4)
        {
            Dictionary<string, string> jsonDictionary = new Dictionary<string, string>
            {
                { "question", question },
                { "c_answer1", c_answer1 }, // correct answer
                { "w_answer2", w_answer2 },
                { "w_answer3", w_answer3 },
                { "w_answer4", w_answer4 }
            };

            TriviaMessage addQuestionMessage = new TriviaMessage
            {
                Code = (int)TriviaRequest.ADD_QUESTION,
                Content = JsonConvert.SerializeObject(jsonDictionary)
            };
            return addQuestionMessage.ToString();
        }
    }
}