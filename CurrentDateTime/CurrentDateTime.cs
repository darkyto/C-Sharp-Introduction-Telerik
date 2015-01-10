using System;

//Create a console application that prints the current date and time
class CurrentDateTime
{
    static void Main()
    {
        DateTime actDate = DateTime.Now;
        Console.WriteLine("Exact date and hour: " + actDate);

        int howDays = DateTime.DaysInMonth (2015, 1); // arguments 4-digit year , 1-12 for month
        Console.WriteLine("This month has "+ howDays +" days!");

        bool leapYear = DateTime.IsLeapYear(2015); // IsLeapYear check if the year is leap or not - argument 4-digits of the year. TRUE OR FALSE boolean statement
        Console.WriteLine("The year 2015 is LEAP!? True or False!? Press any key to see the answer!");
        Console.Read(); 
        Console.WriteLine(leapYear);
        Console.WriteLine();
        Console.WriteLine("I have waisted a few seconds of your time - check it out : "+ DateTime.Now); 
        //using directly DateTime.Now function - please notice that if you use again actDate 
        //it will return the old time stored by the variable and there will be no difference in the time.
    }
}
