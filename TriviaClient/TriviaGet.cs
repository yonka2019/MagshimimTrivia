using System;
using System.Collections.Generic;

namespace TriviaClient
{
    internal class TriviaGet
    {
        public static object[] GetRooms()
        {
            string sendRoomsMsg = TriviaProtocol.GetRooms();
            Socket.SendMsg(sendRoomsMsg);

            string recvRoomsMsg = Socket.RecvMsgByResponse((int)TriviaResponse.GET_ROOMS);
            if (recvRoomsMsg != null)
            {
                TriviaMessage roomsMessage = new TriviaMessage(recvRoomsMsg);
                try
                {
                    return (object[])roomsMessage.ToMultiDict()["Rooms"];
                }
                catch
                {
                    return null;
                }
            }
            return null;
        }

        public static object[] GetUsersInRoom(int roomId) // calls MenuRequestHandler->getPlayersInRoom
        {
            string sendUsersMsg = TriviaProtocol.GetUsersInRoom(roomId);
            Socket.SendMsg(sendUsersMsg);

            string recvUsersMsg = Socket.RecvMsgByResponse((int)TriviaResponse.GET_PLAYERS);
            if (recvUsersMsg != null)
            {
                TriviaMessage usersMessage = new TriviaMessage(recvUsersMsg);

                return (object[])usersMessage.ToMultiDict()["PlayersInRoom"];
            }
            return null;
        }

        public static Dictionary<string, object> GetCurrentRoomState()
        {
            string sendRoomStateMsg = TriviaProtocol.GetCurrentRoomState();
            Socket.SendMsg(sendRoomStateMsg);

            string recvRoomStateMsg = Socket.RecvMsgByResponse((int)TriviaResponse.GET_ROOM_STATE, (int)TriviaResponse.LEAVE_ROOM, (int)TriviaResponse.START_GAME);

            if (recvRoomStateMsg != null)
            {
                TriviaMessage roomStateMessage = new TriviaMessage(recvRoomStateMsg);

                switch (roomStateMessage.Code)
                {
                    case (int)TriviaRequest.GET_ROOM_STATE:
                        return roomStateMessage.ToMultiDict();

                    case (int)TriviaRequest.LEAVE_ROOM:
                        throw new RoomClosedException();

                    case (int)TriviaRequest.START_GAME:
                        throw new GameStartedException();
                }
            }
            return null;
        }

        public static int GetRoomId(object[] rooms, string roomName)
        {
            if (rooms != null && roomName != null)
            {
                foreach (Dictionary<string, object> room in rooms)
                {
                    if (room["name"].ToString() == roomName)
                        return Convert.ToInt32(room["id"]);
                }
            }
            return -1;
        }

        public static Dictionary<string, object> GetRoomByName(object[] rooms, string roomName)
        {
            foreach (Dictionary<string, object> room in rooms)
            {
                if (room["name"].ToString() == roomName)
                    return room;
            }
            return null;
        }

        public static object[] GetPersonalStatistics()
        {
            string sendPersonalStatisticsMsg = TriviaProtocol.GetPersonalStatistics();
            Socket.SendMsg(sendPersonalStatisticsMsg);

            string recvPersonalStatisticsMsg = Socket.RecvMsgByResponse((int)TriviaResponse.GET_PERSONAL_STATS);
            if (recvPersonalStatisticsMsg != null)
            {
                TriviaMessage personalStatisticsMessage = new TriviaMessage(recvPersonalStatisticsMsg);

                return (object[])personalStatisticsMessage.ToMultiDict()["UserStatistics"];
            }
            return null;
        }

        public static object[] GetHighScoresStatistics()
        {
            string sendHighScoresMsg = TriviaProtocol.GetHighScore();
            Socket.SendMsg(sendHighScoresMsg);

            string recvHighScoresMsg = Socket.RecvMsgByResponse((int)TriviaResponse.GET_HIGHSCORE);
            if (recvHighScoresMsg != null)
            {
                TriviaMessage highScoresMessage = new TriviaMessage(recvHighScoresMsg);
                return (object[])highScoresMessage.ToMultiDict()["HighScores"];
            }
            return null;
        }

        public static Dictionary<string, object> GetQuestion()
        {
            string sendGetQuestionMsg = TriviaProtocol.GetQuestion();
            Socket.SendMsg(sendGetQuestionMsg);

            string recvGetQuestionMsg = Socket.RecvMsgByResponse((int)TriviaResponse.GET_QUESTION);
            if (recvGetQuestionMsg != null)
            {
                TriviaMessage getQuestionMessage = new TriviaMessage(recvGetQuestionMsg);

                if ((int)getQuestionMessage.ToMultiDict()["status"] == (int)TriviaResponse.SUCCESS)
                    return getQuestionMessage.ToMultiDict();
                else
                    System.Windows.Forms.MessageBox.Show("Can't get question", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return null;
        }

        public static object[] GetGameResults()
        {
            string sendGetGameResults = TriviaProtocol.GetGameResults();
            Socket.SendMsg(sendGetGameResults);

            string recvGetGameResults = Socket.RecvMsgByResponse((int)TriviaResponse.GET_GAME_RESULT);
            if (recvGetGameResults != null)
            {
                TriviaMessage getGameResultsMessage = new TriviaMessage(recvGetGameResults);
                try
                {
                    return (object[])getGameResultsMessage.ToMultiDict()["Results"];
                }
                catch
                {
                    return null;
                }
            }
            return null;
        }

        public static bool IsRoomActive(string roomName)
        {
            object[] rooms = GetRooms();
            if (rooms != null)
            {
                foreach (Dictionary<string, object> room in rooms)
                {
                    if ((string)room["name"] == roomName)
                        return (int)room["isActive"] == 1;
                }
            }
            return false;
        }

    }
}