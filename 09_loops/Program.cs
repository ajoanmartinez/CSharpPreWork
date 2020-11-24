using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //int number = 0; // number is called a loop control variable or (LCV)
            //2
            //while (number <= 100)
            //{
            //3
            //    Console.WriteLine(number);
            //    number = number + 5;
            //4
            //}
            //5
            //Console.ReadLine();

            //int number = 10;

            //1         //2       //3
            //for (int i = 1; i <= number; i++) // i is the loop control variable (LCV)
            //{
            //4
            //    Console.WriteLine(i);
            //}
            //5



            //Challenges
            //Print the numbers 500 through 525 using a for loop:


            //for (int i = 500; i <= 525; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //Create a for loop that prints the numbers from 0-100 by 5's.

            //for (int i = 0; i <= 100; i += 5)
            //{
            //    Console.WriteLine(i);
            //}


            //or



            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //
            //}



            //Create a for loop that prints the numbers 1-100 to the console. If the # is divisible by 3, print Fizz instead of the number, 
            //if it's divisible by 5, print Buzz, if it's divisible by both 3 and 5, print FizzBuzz otherwise print the number.

            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
