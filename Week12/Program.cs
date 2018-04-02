using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            //to add elements to the stack use the push method
            st.Push("student");
            st.Push("name");
            st.Push("is");
            st.Push("bill");
            foreach (object obj in st)
                Console.Write(obj + " ");
            Console.WriteLine();

            //to remover element from the stack use the pop method
            //it should remove the last one on the top of the stack
            st.Pop();
            //toclear the stack use the clear method
            st.Clear();
            
            //to check the stack
            if (st.Count > 0) Console.WriteLine("stakc is not empty");
            else Console.WriteLine("stack is empty");

            st.Push(10);
            st.Push(20);
            st.Push(30);
            st.Pop();
            foreach (object obj in st)
                Console.WriteLine(obj);




            ///////////////////////////////////////////////////////////////
            ////using construcutor to create string object
            //char[] ch = { 'h', 'e', 'l', 'l', 'o' };
            //string st1 = new string(ch);
            //Console.WriteLine(st1);

            ////the second way to create a string, using start index and length
            //string st2 = new string(ch, 0, 2);
            //Console.WriteLine(st2);

            ////use the length property to get the string length, notice it will count spaces
            //Console.WriteLine("enter a phrase");
            //st1 = Console.ReadLine();
            //Console.WriteLine("the length of the phrase is {0}", st1.Length);

            ////use the static compare method to compare between two strings
            //st1 = "apples";
            //st2 = "bananas";
            //if (string.Compare(st1, st2) == 0) Console.WriteLine("{0} and {1} are equal", st1, st2);
            //else if (string.Compare(st1, st2) < 0) Console.WriteLine("{0} precedes {1}", st1, st2);
            //else Console.WriteLine("{0} follows {1}", st1, st2);

            ////to get sub string from a string
            //st1 = "daylight";
            //Console.WriteLine("substring from daylight is {0}", st1.Substring(3));

            //// to check if a string contains another string inside
            //st1 = "intro to c# programming";
            //if (st1.Contains("C#")) Console.WriteLine("found it");
            //else Console.WriteLine("did not find it");

            ////to convert string to upper case, or lower case use either toUpper or toLower
            //Console.WriteLine("enter a lower case word");
            //st1 = Console.ReadLine();
            //Console.WriteLine("the word {0} in upper case is {1}", st1, st1.ToUpper());

            ////to remove the spaces from the string use the trim method
            //Console.WriteLine("enter a phrase");
            //st1 = Console.ReadLine();
            //Console.WriteLine("the phrase without spaces {0}", st1.Trim());

            //// to remover part of the string
            ////it should remove from the start 3 letters
            //st1 = "sunrise";
            //Console.WriteLine("the new string is {0}", st1.Remove(0, 3));








            //////////////////////////////
            //string s = "hello";
            //s += " how are you";
            ////you can use the square brackets when working with strings but only for read only operations
            //Console.WriteLine(s[3]);
            ////Console.WriteLine(s);
            ////if (s.Equals("hello")) Console.WriteLine("equal");





            Console.ReadKey();


        }
    }
}
