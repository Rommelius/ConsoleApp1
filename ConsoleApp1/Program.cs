using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listofDescription = new List<string>();

            DirectoryInfo d = new DirectoryInfo(@"C:\Users\Rommel Lapuz\Desktop\TOWNSVILLE\Not Done");//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.pdf"); //Getting Text files
            string str = "";
            using (StreamWriter sw = File.AppendText(@"C:\Users\Rommel Lapuz\Desktop\TOWNSVILLE\Not Done\names.txt"))
            {
                foreach (FileInfo file in Files)
                {
                    sw.Write(file.Name + Environment.NewLine);
                    Console.WriteLine(file.Name);
                }
            }


            ////Read in lines from file.
            //foreach (string line in File.ReadLines(@"C:\Users\Rommel Lapuz\Dropbox\Royal Flying Doctors\RFDS Rockhampton\List\items.txt"))
            //{

            //    listofDescription.Add(line);
            //}

            //using (StreamWriter sw = File.AppendText(@"C:\Users\Rommel Lapuz\Dropbox\Royal Flying Doctors\RFDS Rockhampton\List\here.txt"))
            //{

            //    foreach (string line in listofDescription)
            //    {
            //        sw.Write("../uploaded_files/" + line + Environment.NewLine);
            //        Console.WriteLine("../uploaded_files/" + line + Environment.NewLine);
            //    }

            //}

            Console.ReadLine();

        }
    }
}
