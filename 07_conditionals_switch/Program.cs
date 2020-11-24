using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_conditionals_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            // Console.WriteLine("What's your name?");
            // string inputName = Console.ReadLine().ToLower();

            //2
            // switch (inputName)
            // {
                //3
            //     case "fred": // Same as checking: if (inputName == "fred")
            //        Console.WriteLine("Hey Fred, let's go golfing.");
            //       //4
            //        break;
            //    case "karl": // Same as checking: else if (inputName == "karl")
            //        Console.WriteLine("Let's hang.");
            //        break;
            //    case "john": // Same as checking: else if (inputName == "john")
            //        Console.WriteLine("Sorry, I'm busy right now.");
            //        break;
            //    default: // Same as: else
            //        Console.WriteLine("Hey " + inputName + ", can I call you back in a minute?");
            //        break; // This break isn't required
            // }

            //5

            //1
            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine().ToLower(); ;

            //2
            switch (inputName)
            {
                //3
                case "amy":// Same as checking: if (inputName == "Amy")
                    Console.WriteLine("You already voted!.");
                    //4
                    break;
                case "jorge": // Same as checking: else if (inputName == "Jorge")
                    Console.WriteLine("You're registered to vote!");
                    break;
                case "sean": // Same as checking: else if (inputName == "Sean")
                    Console.WriteLine("Congratulations first time voter!");
                    break;
                default: // Same as: else
                    Console.WriteLine("Hey " + inputName + ", have you voted?.");
                    break; // This break isn't required
            }
        }
    }
}
