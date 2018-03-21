 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7PE8
{
    class Program
    {
        public static int GetRange()
        {
            Console.WriteLine("Please enter how many " +
                "scores you want to save: ");
            var range = -1;
            if (!Int32.TryParse(Console.ReadLine(), out
                range))
                return GetRange();
            if (range < 1 || range > 10)
                return GetRange();
            return range;
        }

        static void Main(string[] args)
        {
            int arraySize = GetRange();
            double[] scoreArr = new double[arraySize];
            string inValue = "";
            double sum = 0, intValue;
            Console.WriteLine("Please enter all homework " +
                "scores");
            int counter = 0;
            while(counter < arraySize)
            {
                inValue = Console.ReadLine();
                while(double.TryParse(inValue, out
                    intValue)== false)
                {
                    Console.WriteLine("Invalid input = 0 "
                        + "stored in intValue");
                    inValue = Console.ReadLine();
                }
                sum += intValue;
                scoreArr[counter] = intValue;
                counter++;

            }
            Array.Sort(scoreArr);
            double lowest = scoreArr[0];
            double highest = scoreArr[arraySize - 1];
            sum = sum - lowest - highest;
            double average = sum / arraySize;
            Console.WriteLine("The average grade of the " +
                "scores is: " + average.ToString("N"));
            Console.WriteLine("The lowest score is: " +
                lowest);
            Console.WriteLine("The highest score is: " +
                highest);
            Console.Read();

        }
    }
}
