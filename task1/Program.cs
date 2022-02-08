using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {

        static void Main(string[] args)
        {

            laptop baseObj = new laptop();
            baseObj.price = 500000;
            baseObj.Ram = "32gb";
            baseObj.processor = "1tb";
            baseObj.HardWare = "i7";
            baseObj.lap();

            hp hpobj = new hp();
            hpobj.price = 40000;
            hpobj.Ram = "32Gb";
            hpobj.processor = "3tb";
            hpobj.HardWare = "i8";
            hpobj.lap();

           
        }
    }
}
