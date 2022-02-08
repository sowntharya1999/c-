using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int salary { get; set; }
        public float Experiance { get; set; }

        public static void PromoteEmp(List<Employee> EmployeeList)
        {
            foreach (Employee emp in EmployeeList)
            {
                if (emp.salary >= 30000 && emp.Experiance>=5)//logic condition  
                {
                    Console.WriteLine(emp.Name + " promoted");
                }
            }
        }
    }

    

}
