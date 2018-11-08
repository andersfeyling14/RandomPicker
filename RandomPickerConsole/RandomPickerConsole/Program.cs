using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPickerConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            string line;
            string[] nameArray;
            try
            {
                StreamReader sr = new StreamReader(@"../../names.txt.txt");
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read");
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
