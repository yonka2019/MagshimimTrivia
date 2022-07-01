#include "Question.h"

Question::Question(const string question, const string correctAnswer, const vector<string> wrongAnswers)
{
    this->m_question = question; // set up the question
    this->m_possibleAnswers.push_back(correctAnswer); // insert correct answer (1)

    this->m_possibleAnswers.insert(this->m_possibleAnswers.end(), wrongAnswers.begin(), wrongAnswers.end()); // insert wrong answers (2,3,4)
}


string Question::getQuestion() const
{
    return this->m_question;
}


vector<string> Question::getPossibleAnswers() const
{
    return this->m_possibleAnswers;
}


string Question::getCorrectAnswer() const
{
    return this->m_possibleAnswers[0];
}


bool Question::operator==(const Question& other) const
{
    return this->m_question == other.m_question;
}
