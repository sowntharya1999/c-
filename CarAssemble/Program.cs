using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssemble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assemble AssemblyLine = new Assemble();
            Assemble.SuccessRate();
            Assemble.ProductionRatePerHour();
            Assemble.WorkingItemsPerMinute();


        }
    }
}
