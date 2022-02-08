using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OneDimensionArray Obj1Dimention = new OneDimensionArray();
         //  Obj1Dimention.Onedimention_arr();
            TwoDimentionArray Obj2Dimention = new TwoDimentionArray();
           // Obj2Dimention.TwoDimention_arr();

            JaggedArray OBJjaggedArray = new JaggedArray();
            OBJjaggedArray.Jagged_Arr();

            Console.ReadKey();
        }
    }
}
