using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Computer Programmer";
        job1._company = "Broski Studios";
        job1._startYear = 2023;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._jobTitle = "Website Developer";
        job2._company = "Tech Solutions";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Derek Nielsen";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}