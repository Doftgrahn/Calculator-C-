


using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {   //Declare Variables and init state;
            int num1 = 0; int num2 = 0;

            //Display Title
            Console.WriteLine("Console Calculator in C#");
            Console.WriteLine("________________________");


            //Ask for a number
            Console.WriteLine("Type a number and press Enter!");
            num1 = Convert.ToInt32(Console.ReadLine());

            //ask for a second number
            num2 = Convert.ToInt32(Console.ReadLine());

            //ask To choose an option

            Console.WriteLine("Choose an option of the following list!");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ta - Subtract");
            Console.WriteLine("\ta - Multiply");
            Console.WriteLine("\ta - Divide");
            Console.WriteLine("Your Option?");


            // Use a Switch 

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Your Result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }


            Console.WriteLine("Press any key to close the Calculator console app...");
            Console.ReadKey();

        }
    }
}