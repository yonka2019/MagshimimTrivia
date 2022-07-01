namespace TriviaClient
{
    public enum TriviaRequest
    {
        LOGIN = 102, //from 102
        SIGN_UP,
        CREATE_ROOM,
        GET_ROOMS,
        GET_USERS_IN_ROOM,
        JOIN_ROOM,
        GET_PERSONAL_STATISTICS,
        GET_HIGH_SCORE_STATISTICS,
        LOGOUT,
        CLOSE_ROOM,
        START_GAME,
        GET_ROOM_STATE,
        LEAVE_ROOM,
        LEAVE_GAME,
        GET_QUESTION,
        SUBMIT_ANSWER,
        GET_GAME_RESULT,
        ADD_QUESTION,
        EXIT_CLIENT = 199
    }
}

