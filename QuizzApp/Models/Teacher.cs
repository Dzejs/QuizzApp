using QuizzApp.Enums;

namespace QuizzApp
{
    public class Teacher : User
    {
        public override Role Role { get; set; }
        public Teacher(int id, string userName, string password) : base(id, userName, password)
        {
            Role = Role.Teacher;
        }
    }
}
