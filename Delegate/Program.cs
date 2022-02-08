using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List<Employee> empl = new List<Employee>();
            empl.Add(new Employee() { ID = 101, Name = "Ravi", salary = 20000, Experiance = 3 });
            empl.Add(new Employee() { ID = 102, Name = "John", salary = 30000, Experiance = 5 });
            empl.Add(new Employee() { ID = 103, Name = "Mary", salary = 50000, Experiance = 8 });
            empl.Add(new Employee() { ID = 104, Name = "Mike", salary = 100000, Experiance = 2 });
            Employee.PromoteEmp(empl);*/

           /* Linq linq = new Linq();
            linq.LinqCreation();*/

            add add = new add();
            add.add1();


        }
        class add
        {
            public void add1()
            {
                int a = 5;
                int b = 5;
                int c = a+b;
                Console.WriteLine(c);
            }
        }
    }
}
