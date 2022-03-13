using QuizzApp.Enums;
using QuizzApp.Helpers;
using System;
using System.Linq;

namespace QuizzApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNamePasswordMatch = 0;
            int rightAnswers = 0;

            while (true)
            {
                try
                {
                    if (userNamePasswordMatch > 3)
                    {
                        Console.WriteLine("You entered the wrong username or password more than 3 times!");
                        break;
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }

                while (true)
                {
                    try
                    {
                        var user = UserHelpers.LogIn();
                        if (user == null)
                        {
                            userNamePasswordMatch++;
                            Console.WriteLine("Invalid user!");
                            break;
                        }

                        if (user.Role == Role.Student)
                        {
                            if (user.TestValidation == true)
                                throw new Exception("You have already taken this test!");

                            user.TestValidation = true;

                            var answers = StaticDb.Answers.ToList();
                            for (int i = 0; i < StaticDb.Questions.Count; i++)
                            {
                                if (StaticDb.Questions.Count != (answers.Count / 4))
                                    throw new Exception("Invalid number of questions please change the number of question and answers");

                                Console.WriteLine($"\n{i + 1}.Question {StaticDb.Questions[i].Questionn}");

                                var answersPerQuestion = AnswerHelpers.AnswerPagination(answers.Skip(i * 4).ToList());
                                for (var y = 0; y < answersPerQuestion.Count; y++)
                                {
                                    Console.WriteLine($"{y + 1}.{answersPerQuestion[y].Answerr}");
                                }

                                if (AnswerHelpers.UserAnswer() == StaticDb.Questions[i].RightAnswerId)
                                    rightAnswers++;
                            }

                            Console.WriteLine($"Your grade is {rightAnswers}");
                            break;
                        }
                        else if (user.Role == Role.Teacher)
                        {
                            var testTrue = StaticDb.Users.Where(x => x.TestValidation == true).ToList();
                            var testFalse = StaticDb.Users.Where(x => x.TestValidation == false).ToList();

                            UserHelpers.TestNotTaken(testFalse);
                            UserHelpers.TestTaken(testTrue);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }
    }
}
