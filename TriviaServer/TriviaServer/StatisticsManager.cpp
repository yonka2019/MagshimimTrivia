#include "StatisticsManager.h"

StatisticsManager::StatisticsManager(IDatabase* db): m_database(db)
{
}


vector<Highscore> StatisticsManager::getHighScore() const
{
    std::vector<Highscore> highestScore;
    std::list<std::string> users = this->m_database->getUsers();
    std::multimap<double, std::string> usersStatisticsMap; // <points, username>
    int counter = 0;
    
    // insert into map
    for (auto& user : users)
    {
        usersStatisticsMap.insert({ countPoints(getUserStatistics(user)), user });
    }


    // push from map into vector (from highest to lowest score)
    for (auto it = usersStatisticsMap.rbegin(); (it != usersStatisticsMap.rend()) && (counter <= AMOUNT_OF_PLAYERS_TO_SHOW); ++it) 
    {
        highestScore.push_back({ it->second, it->first });
        counter++;
    }

    return highestScore;
}


double StatisticsManager::countPoints(const vector<string> usernameStatistics)
{
    double points = 0;

    points += (std::atoi(usernameStatistics[C_ANSWER_INDEX].c_str()) * POINTS_FOR_CORRECT); // right answers 
    points -= (std::atoi(usernameStatistics[W_ANSWER_INDEX].c_str()) * POINTS_FOR_WRONG); // wrong answers
    
    double averageTime = std::stod(usernameStatistics[AVG_TIME_INDEX]);
    if (averageTime != 0)
        points /= std::stod(usernameStatistics[AVG_TIME_INDEX]); // avg answer time

    if (points < 0) // player can't lose score by playing (only gaining score)
    {
        return 0;
    }

    return points;
}


vector<string> StatisticsManager::getUserStatistics(const string username) const
{
    vector<string> user_stats;

    //get stats
    int right_answers = this->m_database->getNumOfCorrectAnswers(username);
    int total_answers = this->m_database->getNumOfTotalAnswers(username);
    float avg_answer_time = this->m_database->getPlayerAverageAnswerTime(username);

    //get stats formatted
    user_stats.push_back(std::to_string(right_answers));
    user_stats.push_back(std::to_string(total_answers - right_answers));
    user_stats.push_back(std::to_string(avg_answer_time));

    return user_stats;
}

