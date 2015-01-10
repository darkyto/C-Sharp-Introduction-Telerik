using System;

//Program to find the First and the Last name of user. Also added additional interactivity
//Program will prompt again if the user do not enter anything ifor Last name.
class FirstLastName
{
    static void Main()
    {

        Console.WriteLine("Gonna ask you one more time! What's your First name!?");
        string firstName = Console.ReadLine();

        Console.WriteLine("Goood! Easy uh!? Now gimme you Last name and we are done!");
        string lastName = Console.ReadLine();

        if (String.IsNullOrEmpty(lastName))
        {
            Console.WriteLine("Come on we don't have all day - Just give me your Last name!");
            string lastNameSecondTry = Console.ReadLine();
            Console.WriteLine("Well thank you {0} {1} and keep to good job going!", firstName, lastNameSecondTry);
            Console.Beep();
        }
        else
        {
            Console.WriteLine("Well thank you {0} {1} and keep to good job going!", firstName, lastName);
            Console.Beep();
        }
    }
}
