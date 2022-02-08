using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{

    class EmpProg
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int salary { get; set; }
        public int Experiance { get; set; }
    }
    internal class Linq
    {

        //linquee
        public void LinqCreation()
        {
            List<EmpProg> empl = new List<EmpProg>()
            {
                new EmpProg() { ID = 101, Name = "Ravi", salary = 20000, Experiance = 3 },
            new EmpProg() { ID = 102, Name = "John", salary = 30000, Experiance = 5 },
            new EmpProg() { ID = 103, Name = "Mary", salary = 50000, Experiance = 8 },
            new EmpProg() { ID = 104, Name = "Mike", salary = 100000, Experiance = 2 }



        };
        var result = from emp in empl
                     where emp.salary >= 30000 && emp.Experiance >= 5
                     select emp;

            foreach (EmpProg emp in result)
            {
                Console.WriteLine(emp.Name + "promted");
            }
       }

    }
}
