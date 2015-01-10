using System;

//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
class PrintLongSequence
{
    static void Main()
    {
        for (int i = 2; i <= 1001; i++)  //loop starting from 2 , up to 1001 , increment with 1
        {
            if (i % 2 == 0) // to return true/false for every first/second member of the loop - in this case odd/even.
            {
                Console.WriteLine(i); 
            }
            else
            {
                Console.WriteLine(-i);
            }
        }
    }
}

