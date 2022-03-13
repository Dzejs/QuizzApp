using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizzApp.Helpers
{
    public static class AnswerHelpers
    {
        public static void Answers(List<Answer> answers)
        {
            for (int i = 0; i < answers.Count; i++)
            {
                Console.WriteLine($"{i + 1} {answers[i].Answerr}");
            }
        }

        public static int UserAnswer()
        {
            Console.WriteLine("Please enter your answer: ");
            string userAnswer = Console.ReadLine();

            if (int.TryParse(userAnswer, out int answerParsed))
                return answerParsed;

            throw new Exception("Invalid answer");
        }

        public static List<Answer> AnswerPagination(List<Answer> answers)
        {
            if (answers.Count % 2 != 0)
                throw new Exception("Invalid number of answers you must have a list of even numbers!");

            var answersPerQuestion = 4;
            var answersPerPage = answers.Take(answersPerQuestion).ToList();

            return answersPerPage;
        }
    }
}
