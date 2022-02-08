using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Squeaky
{
    internal class Identifier
    {
        public static void Clean()
        {
            Console.Write("Task1");
            Console.Write("********");
            string Mystr = "my Id";
            Console.WriteLine(Mystr.Replace(' ', '_'));
            Console.Write("Task2");
            Console.Write("********");
            string Mystr1 = "my\0Id";
            Console.WriteLine(Mystr1.Replace("\0", "CTRL"));
           /* Console.Write("Task3");
            Console.Write("********");
            string Mystr2 = "à-ḃç";
            String[] a = Mystr2[1].*/
          //  Console.WriteLine(Mystr2.ToUpper());
            
            

            string pattern = @"[a-zA-Z]";
            string input = "MyΟβιεγτFinder";
            foreach (Match match in Regex.Matches(input, pattern))
                Console.Write(match.Value);
        }
    }
}
