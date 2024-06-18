using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2010;
        job1._endYear = 2015;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2015;
        job2._endYear = 2018;

        Job job3 = new Job();
        job3._jobTitle = "Chief Executive Officer";
        job3._company = "Google";
        job3._startYear = 2018;
        job3._endYear = 2020;

        Job job4 = new Job();
        job4._jobTitle = "Chief Financial Officer";
        job4._company = "Walmart";
        job4._startYear = 2020;
        job4._endYear = 2022;

        Job job5 = new Job();
        job5._jobTitle = "Chief Marketing Officer";
        job5._company = "Nike";
        job5._startYear = 2022;
        job5._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);
        myResume._jobs.Add(job4);
        myResume._jobs.Add(job5);

        myResume.Display();
    }
}