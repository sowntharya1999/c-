using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squeaky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Identifier ObjIdenti = new Identifier();
            Identifier.Clean();
            Console.ReadKey();
        }
    }
}
