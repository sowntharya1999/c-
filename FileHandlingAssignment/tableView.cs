using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace FileHandlingAssignment
{
    internal class tableView
    {
        public void Readvalues()
        {
            FileStream fileStreamObj = new FileStream("D:\\networklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStreamObj);
            // Console.WriteLine(streamReaderObj.ReadToEnd());
              /* Console.Write("ID");
               Console.Write("                Source");
               Console.Write("                Destination");
               Console.Write("              Date");
               Console.Write("                Status");
               Console.WriteLine("            Network");
*/
            while (streamReaderObj.Peek() >0)
            {
                string linestr = streamReaderObj.ReadLine();
                if (linestr.Contains(":"))
                {
                    if (linestr.StartsWith("Network"))
                    {
                        string[] result = linestr.Split(':');
                        Console.Write(result[1] + "                       ");
                    }
                    else
                    {
                        string[] result = linestr.Split(':');
                        Console.Write(result[1] + "                       ");
                    }
                   
                }
               
            }



        }
        
    }
}
