using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//
//***************************
//              1. Array is Used To store collection of data with same datatype.
//              2.stores a fixed - size sequential collection of element of the same type
//                              int[] array = new int[5] {1,2,3,4,5}
//                              can't assign like this = {1,2,3,4,5,6,7,8}
//
//              3.Instead of declaring individual variables , you declare one array variable
//                              int a=10, int b =15, int c =20;
//                              int[] Array = new int[3]{10,15,20}
//              4.a specific element in an array is accessed by an index.
//                              console.write(Array[0]);
//
//Single Dimention Array     -    Normal Array
//Syntax:  
/*
        1.  int[] arr1 = new int[5];
            arr1[0] = 1;
            arr1[1] = 2;
            arr1[2] = 3;

            all the array array elements are initialized by default with 0.we can overWrite them.

        2. Need to store fixed values in to the array:
           int[] arr2 = new int[5] {10,2,3,4,5};
                            [size fixed]
        3.Free Size

           int[] arr3 = new int[] {1,2,3};

Example =  Find a particular element in the array:
 */
namespace stack
{
    internal class OneDimensionArray
    {
        public void Onedimention_arr()
        {
            int[] arr = new int[] {2,4,3,6,9,8,5};

            Console.Write("Enter the number to search : ");
            int number =Convert.ToInt32( Console.ReadLine());
            bool found = false;
            for(int i = 0; i < arr.Length; i++)
            {
               
                if (number == arr[i])
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                Console.WriteLine("Element Found");
            }
            else
            {
                Console.WriteLine("Element not found");
            }
           
        }
    }
}
