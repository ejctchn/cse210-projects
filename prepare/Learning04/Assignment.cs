public class Assignment
{
    private string student_name;
    private string topic;

    public Assignment(string _student_name, string _topic)
    {
        student_name = _student_name;
        topic = _topic;
    }

    public string GetSummary()
    {
        string concat = student_name + " - " + topic;
        return concat;
    }
}