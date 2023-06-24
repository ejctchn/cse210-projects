public abstract class Goal
{
    string goal_type;
    string goal_name;
    string goal_desc;
    int goal_points;
    string output;
    bool int_entered = false;

    // public Goal(string _goal_type, string _goal_name, string _goal_desc, int _goal_points)
    // {
    //     goal_type = _goal_type;
    //     goal_name = _goal_name;
    //     goal_desc = _goal_desc;
    //     goal_points = _goal_points;
    // }

    public abstract string questions();
}