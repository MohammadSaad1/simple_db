using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_db
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> dict = new SortedDictionary<string, int>();

            dict.Add("Mohammad", 21);
            dict.Add("Poul", 23);
            dict.Add("Jibril", 22);
            dict.Add("Mig", 24);


           


            using (StreamWriter file = new StreamWriter(@"C:\Source\Database.bin"))
                foreach (var entry in dict)
                    file.WriteLine("{0} : {1}", entry.Key, entry.Value);


            using (StreamReader file = new StreamReader(@"C:\Source\Database.bin"))
                Console.WriteLine(file.ReadToEnd());
            Console.ReadLine();


         
        }
    }
}
