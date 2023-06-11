class Activity
{
    private bool keep_going = true;
    public Activity(bool _keep_going)
    {
        keep_going = _keep_going;
    }
    public bool ReturnBool()
    {
        return keep_going;
    }
}