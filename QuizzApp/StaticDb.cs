using System.Collections.Generic;

namespace QuizzApp
{
    public static class StaticDb
    {

        public static List<User> Users = new List<User>()
        {
                    new Student(1, "Bojan", "boki123", false),
                    new Student(2, "Filip", "filip123", false),
                    new Student(3, "Dejan", "dejan123", false),
                    new Student(4, "Zare", "zare123", false),

                    new Teacher(1, "Bob", "bob123"),
                    new Teacher(2, "Jill", "jill123"),
                    new Teacher(3, "Jhon", "jhon123"),
                    new Teacher(4, "Wayne", "wayne123"),
        };

        public static List<Question> Questions = new List<Question>()
            {
                new Question(1, 2, "What is the capital of Tasmania?"),
                new Question(2, 4, "What is the tallest building in the Republic of the Congo?"),
                new Question(3, 3, "Which of these is not one of Pluto's moons?"),
                new Question(4, 2, "What is the smallest lake in the world?"),
                new Question(5, 2, "What country has the largest population of alpacas?")
            };

        public static List<Answer> Answers = new List<Answer>()
            {
                new Answer(1, "Dodoma"),
                new Answer(2, "Hobart"),
                new Answer(3, "Launceston"),
                new Answer(4, "Wellington"),
                new Answer(5, "Kinshasa Democratic Republic of the Congo Temple"),
                new Answer(6, "Palais de la Nation"),
                new Answer(7, "Kongo Trade Centre"),
                new Answer(8, "Nabemba Tower"),
                new Answer(9, "Styx"),
                new Answer(10, "Hydra"),
                new Answer(11, "Nix"),
                new Answer(12, "Lugia"),
                new Answer(13, "Onega Lake"),
                new Answer(14, "Benxi Lake"),
                new Answer(15, "Kivu Lake"),
                new Answer(16, "Wakatipu Lake"),
                new Answer(17, "Chad"),
                new Answer(18, "Peru"),
                new Answer(19, "Australia"),
                new Answer(20, "Nigeria"),
            };
    }
}
