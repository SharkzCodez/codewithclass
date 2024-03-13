using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobRole = "Web Designer";
        job1._companyName = "Microsoft";
        job1._start = 2016;
        job1._end = 2018;

        Job job2 = new Job();
        job2._jobRole = "Project Manager";
        job2._companyName = "Microsoft";
        job2._start = 2020;
        job2._end = 2023;

        Resume myResume = new Resume();
        myResume._name = "Katherine Sunday";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}