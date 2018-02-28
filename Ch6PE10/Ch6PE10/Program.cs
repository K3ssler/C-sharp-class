using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6PE10
{
    class GPA
    {
        static void Main(string[] args)
        {
            int number_of_courses;
            Console.WriteLine("Enter number of courses");
            number_of_courses = Convert.ToInt32(Console.ReadLine());
            char[] grade = new char[number_of_courses];
            int[] number_of_credit_hours = new int[
                number_of_courses];
            for(int i = 0; i < number_of_courses; i++)
            {
                Console.WriteLine("Enter grade A,"
                    + " B, C OR D for course " + (i + 1)
                    + " : ");
                grade[i] =
                    Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter number of credit"
                    + " hours for this course: ");
                number_of_credit_hours[i] = Convert.ToInt32(Console.ReadLine());

            }
            double sum_of_points = 0.0;
            int total_hours = 0;
            for(int i= 0; i < number_of_courses; i++)
            {
                if(grade[i] == 'A' || grade[i] == 'a')
                {
                    sum_of_points = sum_of_points + 4 *
                        number_of_credit_hours[i];
                    total_hours = total_hours +
                        number_of_credit_hours[i];
                }
                else if (grade[i] == 'B' || grade[i] == 'b')
                {
                    sum_of_points = sum_of_points + 3 *
                        number_of_credit_hours[i];
                    total_hours = total_hours +
                        number_of_credit_hours[i];
                }
                else if (grade[i] == 'C' || grade[i] == 'c')
                {
                    sum_of_points = sum_of_points + 2 *
                        number_of_credit_hours[i];
                    total_hours = total_hours +
                        number_of_credit_hours[i];
                }
                else
                {
                    sum_of_points = sum_of_points + 1 *
                        number_of_credit_hours[i];
                    total_hours = total_hours +
                        number_of_credit_hours[i];
                }

            }
            Console.WriteLine(" Number of hours earned ="
                + total_hours);
            Console.WriteLine("GPA is "
                + sum_of_points / total_hours);
            Console.ReadKey(); 
            


        }
    }
}
