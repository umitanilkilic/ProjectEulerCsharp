public class Question
{
    public int id { get; set; }
    public string? answer { get; set; }
}

public class AnswerContainer
{
    public List<Question>? questions { get; set; }
}
