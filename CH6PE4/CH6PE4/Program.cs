using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH6PE4
{
    class AverageScore
    {
        static void Main(string[] args)
        {
         
            int test = 0;
            int score;
            int n = 0;
            double sum = 0.0;
            double average;
            char grade = 'A';
            Console.WriteLine("Enter scores for"
                + " data set 1");
            Console.WriteLine("Type -99 to terminate"
                + " the input");
            Console.WriteLine("Enter your score");
            score = Convert.ToInt32(Console.ReadLine());
            while(test != -99)
            {
                sum = sum + score;
                n++;
                if (int.TryParse(Console.ReadLine(),
                    out test)
                == true && (test >= 0 && test <= 100))
                    score = test;
                else
                    Console.WriteLine("Invalid input");
            }
            Console.WriteLine("Enter scores for"
                + "second data set");
            Console.WriteLine("Type -99 to terminate"
                + " the input");
            Console.WriteLine("Enter your score");
            if (int.TryParse(Console.ReadLine(),
                    out test)
                == true && (test >= 0 && test <= 100))
                score = test;
            while (test != -99)
            {
                sum = sum + score;
                n++;
                if (int.TryParse(Console.ReadLine(),
                    out test)
                == true && (test >= 0 && test <= 100))
                    score = test;
                else
                    Console.WriteLine("Invalid input");
            }
            average = sum / n;
            if (average >= 90 && average <= 100)
                grade = 'A';
            else if (average >= 80 && average <= 89)
                grade = 'B';
            else if (average >= 70 && average <= 79)
                grade = 'C';
            else if (average >= 60 && average <= 69)
                grade = 'D';
            else if (average >= 50 && average <= 59)
                grade = 'F';
            Console.WriteLine("Your grade is: "
                + grade);
            Console.ReadKey();



        }
    }
}
