using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();
        Resume resume1 = new Resume();
        
        job1._job_title = "Quality Assurance Engineer";
        job1._company = "Church of Jesus Christ of Latter-day Saints";
        job1._start_year = 2023;
        job1._end_year = 2023;

        job2._job_title = "Quality Control Inspector";
        job2._company = "Clean Control Corporation";
        job2._start_year = 2018;
        job2._end_year = 2018;

        //job1.Display();
        //job2.Display();

        resume1.name = "Eli Cutchen";
        resume1.job_list.Add(job1);
        resume1.job_list.Add(job2);

        resume1.Display();
    }
}