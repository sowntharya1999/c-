using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace powerOf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (isPowerOfTwo(n))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            int m, sum = 0;
            while (n > 0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            Console.WriteLine(sum);

        }
        static bool isPowerOfTwo(int n)
        {
            return (int)(Math.Ceiling((Math.Log(n) / Math.Log(2))))
                  == (int)(Math.Floor(((Math.Log(n) / Math.Log(2)))));
        }



    }
    

    
}
