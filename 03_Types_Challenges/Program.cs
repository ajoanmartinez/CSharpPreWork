using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Types_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int streetNumber;
            int birthYear = 1978;

            string bookTitle;
            string movieTitle = "Terminator";

            bool isChild;
            bool isParent = true;

            decimal savingsBalance;
            decimal checkingBalance = 500.5M;

            float gallonsOfWater;
            float weight = 162.8f;

            double microGrams;
            double oneThird = 3.3333333333d;

            bookTitle = "Green Eggs and Ham";

            Console.WriteLine(bookTitle);
            Console.WriteLine(weight);
            Console.WriteLine(oneThird);
            Console.WriteLine(bookTitle + " " + isParent);
            int bYear = Int32.Parse("1978");
            Console.WriteLine("I was born in {0}.", bYear);

        }
    }
}
