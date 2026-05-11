using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a resume
        Resume myResume = new Resume();
        myResume._name = "John Doe";

        // Add jobs to the resume
        Job job1 = new Job();
        job1._company = "Company A";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2015;
        job1._endYear = 2018;

        Job job2 = new Job();
        job2._company = "Company B";
        job2._jobTitle = "Senior Software Engineer";
        job2._startYear = 2018;
        job2._endYear = 2021;

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display the resume
        myResume.Display();
    }
}