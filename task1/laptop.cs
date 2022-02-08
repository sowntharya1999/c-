using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program for creating Laptop. Name, Price, Processor,
//Ram and Hard drive should be defined in base class.
//You need to inherit these functionalities in your program and Print Details.
//All the laptop should have different name, price, processor, ram and hard drive.
namespace task1
{
    internal class laptop
    {
      
        public int price;
        public string processor;
        public string Ram;
        public string HardWare;
        public void lap()
        {
            Console.WriteLine("laptop price is : " + price);
            Console.WriteLine("laptop Processor is : " + processor);
            Console.WriteLine("laptop Ram is : " + Ram);
            Console.WriteLine("laptop Hardware is : " + HardWare);

        }
    }

    internal class hp : laptop 
    {
        public string name = "Hp";
       
        public void Hp_lap()
       {
            Console.WriteLine("Laptop Name is : " + name);
            Console.WriteLine("laptop price is : " + price);
            Console.WriteLine("laptop Processor is : " + processor);
            Console.WriteLine("laptop Ram is : " + Ram);
            Console.WriteLine("laptop Hardware is : " + HardWare);

        }
    }
}


