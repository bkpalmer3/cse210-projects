using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Architect";
        job1._company = "We Build Houses";
        job1._startYear = 2018;
        job1._endYear = 2021;

        Job job2 = new Job ();
        job2._jobTitle = "Cashier";
        job2._company = "McDonalds";
        job2._startYear = 2014;
        job2._endYear = 2018;

        Resume myResume = new Resume();
        myResume._name = "Abigail Kent";
        myResume._jobList.Add (job1);
        myResume._jobList.Add (job2);

        myResume.DisplayResume ();

    }
}