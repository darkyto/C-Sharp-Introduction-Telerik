using System;


class SquareNumber
{
    static void Main()
    {

        Console.WriteLine("The square root of the number 12345");
        double a = Math.Sqrt(12345);
        Console.WriteLine("The answer is " + a);

        // Create a console application that calculates and prints the square root of the number 12345.
        // Console.WriteLine("The square root of the number 12345 is {0} " , Math.Sqrt(12345)) ;  (another simple solution)

        Console.WriteLine("Enter your own random number and I will give you root swuare for FREE only NOW!");

        string strUser = Console.ReadLine();

        double c = double.Parse(strUser);

        double d = Math.Sqrt(c);

        Console.BackgroundColor = ConsoleColor.Blue;
        Console.WriteLine("The square root of {0} is {1}", c, d + " and you got that for FREE you lucky..!");

        // Some interaction- Ask user for a random number and give him back the square root 
        // reading the number from the user as string - using ReadLine instead of Read to asure all symbols are read
        // converting the string to numbers for the math operation - using Parse
        // sqrt math operation 
        // calling the result out with the two variables


    }
}
