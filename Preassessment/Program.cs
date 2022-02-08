using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preassessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            MockTest obj1 = new MockTest();
            string[] input = new string[] { "one", "two", "three", "four", "five" };
            obj1.JoinIt(input);
            obj1.SplitIt(input);
            
           
            string[] Input = new string[] { "seven", "two", "three" };
            obj1.Reverse(Input);

            String input1 = "onetwoThree";
            int n = 15;
            char a = '~';
            obj1.Padleft(input1,n,a);
        }
    }

}
