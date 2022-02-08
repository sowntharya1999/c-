using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace salonTask
{
    internal class salon
    {
        public void SalonTask()
        {

           /* var cultureInfo = new CultureInfo("de-DE");*/
            Console.WriteLine("Task 1");
            Console.WriteLine("**********");
            Console.Write("Enter Your Appoinment : ");
            DateTime dateString = new DateTime();



            dateString = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Enter AM/PM : ");
            String time = Console.ReadLine();
            DateTime ShowDatetime = new DateTime(dateString.Year ,dateString.Month,dateString.Day,dateString.Hour,dateString.Minute,dateString.Second);
            Console.WriteLine(dateString.Year + ","+ dateString.Month + "," + dateString.Day + "," + dateString.Hour + "," + dateString.Minute + "," + dateString.Second);
            Console.WriteLine("***********");

            Console.WriteLine("Task 2");

            DateTime AppoinmentDate = dateString;
            if (AppoinmentDate <= DateTime.Now)
            {
                Console.WriteLine("Your  appointment has already passed");
            }
            else
            {
                Console.WriteLine("Your  appointment is not  passed");
            }
            Console.WriteLine("**********");



            Console.WriteLine("Task 3");



            DateTime Date = DateTime.Now;
            string date1 = Convert.ToString(Date);
            string date2 = Convert.ToString(dateString);


            string[] authorsList = date1.Split(' ');
            // Console.WriteLine(authorsList[0]);
            string[] authorsList1 = date2.Split(' ');

            // Console.WriteLine(authorsList1[0]);





            if (authorsList[0] == authorsList1[0] && time == "PM")
            {
                Console.WriteLine("You have appoinment is at afternoon");
            }
            else
            {
                Console.WriteLine("you dont have appoinment today  ");
            }



            Console.WriteLine("**********");



            Console.WriteLine("Task 4");
            Console.WriteLine("You have an appointment on " + dateString + " " + time + ".");

            Console.WriteLine("**********");



            Console.WriteLine("Task 5");
            String date3 = new DateTime(2019, 9, 15).ToString();
            Console.WriteLine("The Anniversary date of Salon is " + date3 + ".");
        }
    }
}
