using System;

//Write a program to read your birthday from the console and 
//print how old you are now and how old you will be after 10 years.

class AgeАfterТенYears
{
    static void Main()
    {

        Console.Write("Can I have your Birthday in the following format dd.mm.yyyy: ");

        DateTime birthYear = DateTime.Parse(Console.ReadLine());
    

        int actualYear = DateTime.Today.Year - birthYear.Year;
        int actualMonth = DateTime.Today.Month - birthYear.Month;
        int actualDay = DateTime.Today.Day - birthYear.Day;
        Console.WriteLine("You are " + actualYear + " years old");
        Console.WriteLine("After 10 Years you will be {0} yeaers old ", actualYear + 10);
        Console.WriteLine("and probaly will be younger that I am RIGHT NOW.. Hallelujah!");

        if (DateTime.Today.Month < birthYear.Month || DateTime.Today.Day < birthYear.Day)
        {
            actualMonth *= -1;
            actualDay *= -1;
            Console.WriteLine("You have {0} months and {1} days until your next birthday", actualMonth, actualDay);
        }
        else
        {
            Console.WriteLine("HEY HEY HEY ! Happy Birthday - We Dring Whiskey in a Jar!");
        }

    }
}
