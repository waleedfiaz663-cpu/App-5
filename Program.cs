using System;

namespace Assignment2_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num1 = 45;
            int num2 = 78;

            Console.WriteLine($"Comparing numbers: {num1} and {num2}");

           
            if (num1 > num2)
            {
                Console.WriteLine("");

                Console.WriteLine($"The greater number is: {num1}");
            }

            else if (num2 > num1)
            {
                Console.WriteLine("");

                Console.WriteLine($"The greater number is: {num2}");
            }

            else
            {
                Console.WriteLine("Both numbers are equal.");
            }

            
            Console.WriteLine("\nDisplaying numbers from 1 to 10 using a loop:");

            Console.WriteLine("");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}