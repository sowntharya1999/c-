using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursePrint
{
    
    internal interface Stack
    {
        void push();

        void pop();

    }
    class StackClass : Stack
    {
       public void push()
        {

            /*Console.WriteLine("Enter the number to insert :");
            Length = Convert.ToInt32(Console.ReadLine());*/
            try
            {
                //int Length = 4;
                Stack<int> myStack = new Stack<int>();
                Console.WriteLine("Push Function :");
                Console.WriteLine("************");

                int[] arr = new int[4] { 1, 2, 3, 4 };
                Stack<int> myStack1 = new Stack<int>(arr);
               /* if(Array.IndexOf(arr,Length) ==4)*/
                myStack1.Push(5);
                myStack1.Push(55);

                foreach (var item in myStack1)
                    Console.WriteLine(item);
            }
            catch (Exception ex1)
            {
                Console.WriteLine("Array size exceed : ");
            }
            
        }
        public void pop() 
        {
            try{
                Console.WriteLine("Pop Function :");
                Console.WriteLine("************");
                int[] arr = new int[] { 1,2 };
                Stack<int> myStack1 = new Stack<int>(arr);

                Console.WriteLine("Popped Element : " + myStack1.Pop());
                Console.Write("Array elements is : ");
                foreach (var item in myStack1)
                    Console.Write(item);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }
    }
}
