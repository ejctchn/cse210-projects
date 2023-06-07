public class MathAssignment : Assignment
{
    private string textbookSection;
    private string problems;

    public MathAssignment(string _student_name, string _topic, string _textbookSection, string _problems) : base(_student_name, _topic)
    {
        textbookSection = _textbookSection;
        problems = _problems;
    }

    public string GetHomeworkList()
    {
        string concat_hw = "Section " + textbookSection + " Problems " + problems;
        return concat_hw;
    }
}