using System;

//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
class SequencePrint
{
    static void Main()
    {

        Console.WriteLine("Program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...");

        for (int actNum = 2; actNum <= 11; ++actNum) //Also instead of ++actNum or actNum++ We can use actNum=(actNum+1)
        {
            if (actNum % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(actNum);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(-actNum);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        //Ordinary loop to make a increasing (by 1) sequence from 2 to 11 - Then added conditions to change the sigh
        //for every number which can not be divied by 2. Instead of using complex mathematical methods we are simply changing signs
        //However using --actNum insted of ++actNum will cause this program to go in endless loop! Try it its insane!:)
        //If we needed to start with negative number then just change the condition to (actNum % 2 == 1) and it will work.
        //Changing the colors of numbers also shows that additional instructions can be embed in if-else statement.
    
    }
}
