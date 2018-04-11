using System;
using System.Collections.Generic;


namespace CH7PE10
{
    class courseClass
    {
        public string courseName;
        public int currentEnrollment;
        public int maxEnrollment;


        static void Main(string[] args)
        {
            Console.WriteLine("Course Enrollment");
            Console.Write("Enter the number" +
                " of courses");
            int number_Of_Courses = -1;
            string x = Console.ReadLine();
            number_Of_Courses = Convert.ToInt32(x);
            for (int i = 1; i <= number_Of_Courses; i++)
            {
                Console.WriteLine("\nEnter "
                    + i.ToString()
                    + " course enrollment\n");
                getCourseRecords();
            }
            DisplayRecords();
            char k = Console.ReadKey().KeyChar;



        }
    }

    class coursesClass
    {
        public List courseList = new List();
        public int cMax;
        public int insertRecord(string name, int currentEnroll, int maxEnroll)
        {
            courseClass courseObj = new courseClass();
            courseObj.courseName = name;
            courseObj.currentEnrollment = currentEnroll;
            courseObj.maxEnrollment = maxEnroll;
            courseList.Add(courseObj);
            cMax = courseList.Count;
            return 1;

        }
    }

    class mainTest
    {
        static public coursesClass cs = new coursesClass();
        static public void DisplayRecords()
        {
            Console.WriteLine("_________" +
                "___________________" +
                "___________________" +
                "___________________");
            Console.WriteLine("NO course " +
                "Name currentEnroll" +
                " MaxEnroll");
            Console.WriteLine("____________" +
                "____________________" +
                "____________________" +
                "____________________");
            for (int i = 0; 1 < cs.cMax; i++)
            {
                Console.Write("{0, -5}",
                i + 1);
                Console.Write("{0, -19}",
                    cs.courseList[i].courseName);
                Console.Write("{0, -7}",
                    cs.courseList[i].currentEnrollment);
                Console.Write("{0, -7}",
                    cs.courseList[i].maxEnrollment);
            }
            Console.WriteLine("___________________" +
                "_______________________" +
                "_______________________" +
                "_______________________");
        }

        static public void getCourseRecords()
        {
            Console.Write("Course Name: ");
            string n;
            int c, m;
            n = Console.ReadLine();
            Console.Write("Enter current enrollment");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter max enrollment");
            m = Convert.ToInt32(Console.ReadLine());
            cs.insertRecord(n, c, m);
        }

    }

}
