using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5PE6
{
    class Program
    {
        static void Main()
        {
            string fig;
            Console.WriteLine("Enter the names for calcualting the area: \n Circle for area of circle\n Rectangle for area of rectangles\n Cyclinder for surface area of cylinder");
            fig = Console.ReadLine();
            input(fig);
            Console.Read();
        }
        static void input(string fig)
        {
            double a,b;
            int hei;
            if (fig == "Circle" || fig == "circle" || fig == "CIRCLE")
            {
                Console.WriteLine("You choose to find the area of a circle");
                Console.WriteLine("Enter the radius of the circle");
                a = Convert.ToDouble(Console.ReadLine());
                area(a);

            }
            else if (fig == "Rectangle" || fig == "rectangle" || fig == "RECATANGLE")
            {
                Console.WriteLine("You've choosen to find the area of a rectangle");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the width of a rectangle: ");
                b = Convert.ToDouble(Console.ReadLine());
                area(a, b);
            }
            else if (fig == "Cylinder" || fig == "cylinder" || fig == "CYLINDER")
            {
                Console.WriteLine("You've choosen to find the area of a cylinder");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the height of cylinder: ");
                hei = Convert.ToInt32(Console.ReadLine());
                area(a, hei);
            }
            else
            {
                Console.WriteLine("Incorrect choice");
                Main();
            }

        }
        static void area(double radius)
        {
            double area;
            area = 3.14 * radius * radius;
            Console.WriteLine("The area of a circle is:" + area + "square units. ");

        }
        static void area(double len, double width)
        {
            double area;
            area = len * width;
            Console.WriteLine("The area of a rectangle is:"
                + area + "square units.");
        }
        static void area(double radi, int height)
        {
            double area;
            area = (2 * 3.14 * radi * height) + (2 * 3.14 * radi
                * radi);
            Console.WriteLine("The surface area of the cylinder is: " + area + "square units");

        }
    }
}
