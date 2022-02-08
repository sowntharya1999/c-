using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursePrint
{
    //constructor
    internal class Course
    {
        public string Name { get; set; }
        public string Duration { get; set; }

        public int Coursefee { get; set; }

        public void print(string name, string duration, int coursefee)
        {
           this.Name = name;
           this. Duration = duration;
            this.Coursefee = coursefee;

            Console.WriteLine("Name is : " +name +"\t"+ "Duration is : " + Duration + "\t" + "Coursefee is : " + Coursefee);
        }

        public void GetTotalFee(int totFee)
        {
            Console.WriteLine("Total fee is : " + totFee);
        }
    }

    class PartTime : Course
    {
        
        public void OnsiteCalculation()
        {
           string CompanyName = "Caresoft Global";
           int No_of_candidates = 500;
            double hike = 0.1;
           
            int sal_increment = Convert.ToInt32(hike * Coursefee);
          
            int onsite_fee = sal_increment + Coursefee;
            Console.WriteLine("Onsite Details");
            Console.WriteLine("************");
            Console.WriteLine("Company Name is :" + CompanyName);
            Console.WriteLine("No_of_candidates is :" + No_of_candidates);
            Console.WriteLine("Total Salary : " + onsite_fee);
        }

        public void PartTimeFeeCalculation()
        {
            String Timing = "4-6 Pm";
            double discount = 0.1;
            int sal_increment = Convert.ToInt32(discount * Coursefee);

            int Part_fee =   Coursefee - sal_increment;
            Console.WriteLine("Part Time Details");
            Console.WriteLine("************");
            Console.WriteLine("Timing :" + Timing);
            Console.WriteLine("Total Salary : " + Part_fee);
        }
    }
   

}
