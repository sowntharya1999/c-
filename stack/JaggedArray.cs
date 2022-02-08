using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Jagged Array
//A jagged array is an array whose elements are arrays, possibly of different sizes.
//A jagged array is sometimes called an "array of arrays."
// Syntax:
/*              int[][] arr = new int[3][];
 *              [int array of arrays]
 *              arr[0] = new [3] {1,2,3};
 *              arr[1] = new [2] {10,20};
 *              arr[2] = new [3] {11,22,33,44};
 * */
namespace stack
{
    internal class JaggedArray
    {
        public void Jagged_Arr()
        {
            int[][] arr = new int[5][];
            arr[0] = new int[5] {10, 3, 4, 3, 7};
            arr[1] = new int[4] { 10, 3, 4, 3 };
            arr[2] = new int[3] { 10, 3, 4 };
            arr[3] = new int[2] { 10, 3 };
            arr[4] = new int[1] { 10};
            
            foreach (int[] i in arr)
            {
                foreach (int j in i)
                {
                    Console.Write(j + "\t");
                }

                Console.WriteLine();
            }
            
        }
    }
}
