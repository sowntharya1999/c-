using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSyatem
{
    internal class FileGenerate
    {
            public void Filecreate()
        {
         FileStream fileStreamObj = new FileStream("D:\\MyTempFile.txt", FileMode.Create, FileAccess.Write);
           StreamWriter streamWriterObj = new StreamWriter(fileStreamObj);
          //  streamWriterObj.WriteLine("Welcome");

            Console.Write("Enter the no of call :  ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.Write("ID : ");
                long ID = Convert.ToInt64(Console.ReadLine());
                streamWriterObj.WriteLine("ID :" + ID);
                Console.Write("Source : ");
                long source = Convert.ToInt64(Console.ReadLine());
                streamWriterObj.WriteLine("Source :" + source);
                Console.Write("Destination : ");
                long Destination = Convert.ToInt64(Console.ReadLine());
                streamWriterObj.WriteLine("Destination :" + Destination);
                Console.Write("Date : ");
                DateTime Date = Convert.ToDateTime(Console.ReadLine());
                string time = Console.ReadLine();
                streamWriterObj.WriteLine("Date :" + Date + " " + time);
                Console.Write("Status : ");
                string Status = Console.ReadLine();
                streamWriterObj.WriteLine("Status :" + Status);
                Console.Write("Netword : ");
                string Network = Console.ReadLine();
                streamWriterObj.WriteLine("Netword :" + Network);
                Console.WriteLine("");


            }
            streamWriterObj.Close();
            fileStreamObj.Close();

        }
    }
}
