using QuizzApp.Enums;
using System;

namespace QuizzApp
{
    public abstract class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        private string Password { get; set; }
        public abstract Role Role { get; set; }
        public bool TestValidation { get; set; }
        public int userNamePasswordMatch = 0;

        public User(int id, string userName, string password)
        {
            Id = id;
            UserName = userName;
            Password = password;
        }

        public User LogIn(string userName, string password)
        {
            if (UserName != userName)
            {
                return null;
            }

            if (Password != password)
            {
                throw new Exception("Invalid password or username");
            }
            else return this;
        }
    }
}
