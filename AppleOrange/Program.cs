using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleOrange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.DistanceCal();
        }

        public  void DistanceCal()
        {
            int[] start_end = new int[10];
            int[] tree = new int[10];
            int[] app_orange = new int[10];
            int[] no_ofApple = new int[10];
            int[] no_ofOrrange = new int[10];
            int result1, result2, result3;
            int resultOrange1, resultOrange2;
            int count = 0;
            int count1=0;
          
            for (int i = 0; i < 2; i++) { 
             start_end[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 2; i++)
            {
                 tree[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0;i < 2; i++)
            {
                 app_orange[i] = Convert.ToInt32(Console.ReadLine());
            }
            for( int i = 0;i<3 ; i++)
            {
                 no_ofApple[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(var i = 0;i<2 ; i++)
            {
                no_ofOrrange[i] = Convert.ToInt32(Console.ReadLine());
            }

            
                result1 = tree[0] + no_ofApple[0];
                result2 = tree[0] + no_ofApple[1];
                result3 = tree[0] + no_ofApple[2];
                Console.WriteLine(result1 + " " + result2+" "+ result3);
            
                if ((result1 >=7 || result1 <=11 ) || (result2 >= 7 || result2 <= 11) || (result3 >= 7 || result1 <= 11))
                {
                    Console.WriteLine(count = count + 1);
                }
            /*if (result1 >= 7 && result1 <= 11)
            {
                for (int j = 0; j < 3; j++)
                {
                    count = count + 1;
                }
            }

            Console.WriteLine(count);*/



            resultOrange1 = tree[1] + no_ofOrrange[0];
            resultOrange2 = tree[1] + no_ofOrrange[1];
            Console.WriteLine(resultOrange1 + " " + resultOrange2);

            if ((resultOrange1 >= 7 || resultOrange1 <= 11) || (resultOrange2 >= 7 || resultOrange2 <= 11) )
            {
                Console.WriteLine(count1 = count1 + 1);
            }

        }
    }
    
}
