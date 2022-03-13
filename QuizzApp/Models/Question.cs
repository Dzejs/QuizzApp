namespace QuizzApp
{
    public class Question
    {
        public int Id { get; set; }
        public int RightAnswerId { get; set; }
        public string Questionn { get; set; }

        public Question(int id, int rightAnswerId, string question)
        {
            Id = id;
            RightAnswerId = rightAnswerId;
            Questionn = question;
        }

    }
}
