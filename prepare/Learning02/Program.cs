using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1=new Job();
        job1._jobTitle ="junior";
        job1._company ="microsoft";
        job1._startYear=2018;
        job1._endYear=2020;
    
        Job job2=new Job();
        job2._jobTitle ="senior";
        job2._company ="apple";
        job2._startYear=2021;
        job2._endYear=2022;

        Resume myResume=new Resume();

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);


        myResume.Display();
    }
}
