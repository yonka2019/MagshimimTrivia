namespace TriviaClient
{
    public enum TriviaResponse
    {
        ERROR = 101, // from 101
        LOGIN,
        SIGNUP,
        LOGOUT,
        GET_ROOMS,
        GET_PLAYERS,
        GET_HIGHSCORE,
        GET_PERSONAL_STATS,
        JOIN_ROOM,
        CREATE_ROOM,
        CLOSE_ROOM,
        START_GAME,
        GET_ROOM_STATE,
        LEAVE_ROOM,
        LEAVE_GAME,
        GET_QUESTION,
        SUBMIT_ANSWER,
        GET_GAME_RESULT,
        ADD_QUESTION,

        SUCCESS = 1,
        FAIL = 0
    }
}