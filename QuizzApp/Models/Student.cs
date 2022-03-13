using QuizzApp.Enums;

namespace QuizzApp
{
    public class Student : User
    {
        public override Role Role { get; set; }

        public Student(int id, string userName, string password, bool testValidation) : base(id, userName, password)
        {
            TestValidation = testValidation;
            Role = Role.Student;
        }
    }
}
