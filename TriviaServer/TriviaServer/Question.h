#pragma once

#include <iostream>
#include <vector>
#include <string>

using std::string;
using std::vector;

class Question
{
public:
	Question() = default;
	Question(const string question, const string correctAnswer, const vector<string> wrongAnswers);

	/// <summary>
	/// The function gives the question
	/// </summary>
	/// <returns>The question</returns>
	string getQuestion() const;

	/// <summary>
	/// The function gives all the possible answers
	/// </summary>
	/// <returns>All the possible answers</returns>
	vector<string> getPossibleAnswers() const;

	/// <summary>
	/// The function gives the correct answer
	/// </summary>
	/// <returns>The correct answers</returns>
	string getCorrectAnswer() const;

	/// <summary>
	/// The function compares between two questions
	/// </summary>
	/// <param name="other">Another question to compare between</param>
	/// <returns>True if they both have the same question. False if not</returns>
	bool operator==(const Question& other) const;
	
private:
	string m_question;
	vector<string> m_possibleAnswers;
};