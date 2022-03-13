namespace QuizzApp
{
    public class Answer
    {
        public int Id { get; set; }
        public string Answerr { get; set; }
        public Answer(int id, string answer)
        {
            Id = id;
            Answerr = answer;
        }
    }
}
