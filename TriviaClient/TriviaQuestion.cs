using System;
using System.Collections.Generic;
using System.Linq;

namespace TriviaClient
{
    internal class TriviaQuestion
    {
        /// <summary>
        /// Correct answer in [0] index
        /// </summary>
        private readonly string[] originalAnswers;

        public TriviaQuestion(Dictionary<string, object> question)
        {
            originalAnswers = new string[4];
            Answers = new string[4];

            Question = question["question"].ToString();
            object[] answers = (object[])question["answers"];

            for (int i = 0; i < answers.Length; i++)
            {
                originalAnswers[i] = ((object[])answers[i])[1].ToString();
            }
            Answers = ShuffleAnswers();
        }

        public string Question { get; }

        /// <summary>
        /// Shuffled answers
        /// </summary>
        public string[] Answers { get; private set; }

        /// <summary>
        /// The correct answer is in the [0] index of the ORIGINAL answers order.
        /// </summary>
        public string CorrectAnswer => originalAnswers[0];

        /// <summary>
        /// Shuffle the answers string[] array
        /// </summary>
        /// <returns>new string array of shuffled answers</returns>
        private string[] ShuffleAnswers()
        {
            string[] shuffledAnswers = new string[4];
            Random rnd = new Random();
            do
            {
                shuffledAnswers = originalAnswers.OrderBy(x => rnd.Next()).ToArray();
            } while (originalAnswers.Equals(shuffledAnswers));

            return shuffledAnswers;
        }

        /// <summary>
        /// Finds the id of the requested answer in the original answers order
        /// </summary>
        /// <param name="answer">answer (itself)</param>
        /// <returns>index of the requested answer in the original answers array</returns>
        public int GetAnswerId(string answer)
        {
            for (int i = 0; i < originalAnswers.Length; i++)
            {
                if (originalAnswers[i] == answer)
                    return i;
            }
            return -1;
        }
    }
}
