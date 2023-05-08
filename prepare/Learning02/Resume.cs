public class Resume
{
    public string name;
    public List<Job> job_list = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine("Jobs:");

        // Notice the use of the custom data type "Job" in this loop
        foreach (Job job in job_list)
        {
            // This calls the Display method on each job
            job.Display();
        }
    }
}