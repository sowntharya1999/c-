using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingAssignment
{
    internal class Net
    {
        public void Array()
        {
            /* Console.Write("Enter a file name : ");
             string path = Console.ReadLine();*/

            FileStream fileStreamobj = new FileStream("D:\\networklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderobj = new StreamReader(fileStreamobj);
            Console.WriteLine("ID\tSource\t\tDestination\tDate\t\tStatus\t\tNetwork");
            string[] ida = new string[15];
            string[] sourcea = new string[15];
            string[] desa = new string[15];
            string[] datea = new string[15];
            string[] statusa = new string[15];
            string[] neta = new string[15];


            int i = 0;
            while (streamReaderobj.Peek() > 0)
            {
                string line = streamReaderobj.ReadLine();
                if (line.Contains(":"))
                {
                    if (line.StartsWith("Id"))
                    {
                        string[] id = line.Split(':');
                        ida[i] = id[1];

                    }
                    else if (line.StartsWith("Source"))
                    {
                        string[] source = line.Split(':');
                        sourcea[i] = source[1];

                    }
                    else if (line.StartsWith("Destination"))
                    {
                        string[] des = line.Split(':');
                        desa[i] = des[1];

                    }
                    else if (line.StartsWith("Date"))
                    {
                        string[] date = line.Split(':');
                        string[] datep = date[1].Split(' ');
                        datea[i] = datep[0];

                    }
                    else if (line.StartsWith("Status"))
                    {
                        string[] status = line.Split(':');
                        statusa[i] = status[1];

                    }
                    else if (line.StartsWith("Network"))
                    {
                        string[] network = line.Split(':');
                        neta[i] = network[1];
                        i++;
                    }
                }



            }
            for (int j = 0; j < 13; j++)
            {
                Console.Write(ida[j] + "\t");
                Console.Write(sourcea[j] + "\t");
                Console.Write(desa[j] + "\t");
                Console.Write(datea[j] + "\t");
                Console.Write(statusa[j] + "\t\t");
                Console.WriteLine(neta[j] + "\t");
            }

        }

    }
}
