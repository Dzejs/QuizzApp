using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizzApp.Helpers
{
    public static class UserHelpers
    {
        public static User LogIn()
        {
            Console.WriteLine("Please log in with your username and password");
            Console.WriteLine("Username: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Password: ");
            string password = Console.ReadLine();

            var user = StaticDb.Users.FirstOrDefault(x => x.LogIn(userName, password) != null);

            return user;
        }

        public static void TestNotTaken(List<User> users)
        {
            foreach (var student in users)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n{student.UserName}");
                Console.ResetColor();
            }
        }

        public static void TestTaken(List<User> users)
        {
            foreach (var student in users)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n{student.UserName}");
                Console.ResetColor();
            }
        }
    }
}
