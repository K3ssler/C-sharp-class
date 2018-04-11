using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH8PE4
{
    class namestring
    {
        public string str_split(string fullname)
        {
            string[] names = fullname.ToString().Trim()
                .Split(new char[] { ' ' }, 2);
            string firstName, lastName;
            firstName = names[0];
            lastName = names[1];
            return lastName;
        }
        public int month_year(string birth)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < birth.Length; i++)
            {
                if ((birth[i] >= '0' && birth[i] <= '9'))
                {
                    sb.Append(birth[i]);
                }
            }
            string s = sb.ToString();
            int n = Convert.ToInt32(s) % 100;
            return n;
        }

        public string month(int m)
        {
            string mname = "";
            switch (m)
            {
                case 1:
                    mname = "Jan";
                    break;
                case 2:
                    mname = "Feb";
                    break;
                case 3:
                    mname = "Mar";
                    break;
                case 4:
                    mname = "Apr";
                    break;
                case 5:
                    mname = "May";
                    break;
                case 6:
                    mname = "Jun";
                    break;
                case 7:
                    mname = "Jul";
                    break;
                case 8:
                    mname = "Aug";
                    break;
                case 9:
                    mname = "Sep";
                    break;
                case 10:
                    mname = "Oct";
                    break;
                case 11:
                    mname = "Nov";
                    break;
                case 12:
                    mname = "Dec";
                    break;
                default:
                    mname = "enter a valid value";
                    break;

            }
            return mname;
        }
        public int zip1(int zip)
        {
            int a = 0;
            if (zip.ToString().Length == 5)
            {
                a = zip % 100;
            }
            else
                Console.WriteLine("Enter a valid"
                    + "value");
            return a;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            namestring n = new namestring();
            int count;
            Console.WriteLine("Enter the fullname..."
                + " name followed by space then"
                + " name....");
            string fullname = Console.ReadLine();
            string last = n.str_split(fullname);
            count = fullname.Length;
            Console.WriteLine("Enter your date of"
                + " birth");
            string birth_date = Console.ReadLine();
            int nu = n.month_year(birth_date);
            Console.WriteLine("Enter the month of purchase"
                + "<1-12>....");
            int month = Convert.ToInt32(Console.ReadLine());
            string month_last = n.month(month);
            Console.WriteLine("Enter the zip code");
            int zip = Convert.ToInt32(Console.ReadLine());
            int zip_code = n.zip1(zip);
            Console.WriteLine("\n\n************Mailing"
                + " label: ***************");
            Console.WriteLine(last + nu + count + month_last
                + zip_code);
            Console.Read();
        }
    }
}
