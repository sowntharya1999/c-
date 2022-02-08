using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//MultiDimention Array
//Syntax:
//          1.      int[,] arr1 = new int[2,3] {{1,2,3},{4,5,6}}
//                   [Row, column]         
//          2. int[,] arr2 = new int[,] {{1,2,3},{1,2,3}}
//          3. int[,] arr3 = new int[2,3];
//                   arr3[0,0] =1;
//                   arr3[0,1]= 2;
namespace stack
{
    internal class TwoDimentionArray
    {
        public void TwoDimention_arr()
        {
            int[,] arr = new int[3,4] { { 1,2,3,4} , { 10, 20, 10, 15  } , { 30,1,5,7}  };
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j] + "\t");
                }
                Console.WriteLine();
            }
        
        
        
        }
    }
}
