using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursePrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course ObjCourse = new Course();
            //ObjCourse.print("sownth", "3month", 10000);
            PartTime partTime = new PartTime();
           partTime.print("B.tech", "3Years", 15000);
            partTime.OnsiteCalculation();
            partTime.PartTimeFeeCalculation();



            StackClass ObjStack = new StackClass();
            ObjStack.push();
            ObjStack.pop();
        }
    }
}
