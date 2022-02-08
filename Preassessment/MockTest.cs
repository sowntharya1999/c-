using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preassessment
{
    internal class MockTest

    {
        public void JoinIt(string[] Input)
        {
            Console.WriteLine("Joint task : ");
            //  string[] input = new string[] { "one", "two", "three", "four", "five" };
            string s1 = string.Join("~", Input);
            Console.WriteLine(s1);
         }
        public void SplitIt(String[] Input)
        {
            Console.WriteLine("Split task : ");
            string s1 = string.Join("~", Input);
            String[] strlist = s1.Split('~');
            Console.WriteLine(strlist[3]);
        }
        public void Reverse(string[] Input)
        {
            Console.WriteLine("Reverse task : ");
            string[] temp = Input;
            Console.Write("Original Array: ");
            foreach (string i in Input)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // reverse the array
            Array.Reverse(temp);
            Console.Write("Reversed Array: ");
            foreach (string i in temp)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(" ");
        }
        public void Padleft(string input1, int n, char a)
        {
            Console.WriteLine("Padleft task : ");
            Console.WriteLine("Pad 15 :{0}", input1.PadLeft(n, a));
        }
    }
}
