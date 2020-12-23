using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> m1 = new List<string>();
            m1.Add("murali");
            m1.Add("kumar");

            //for sorting
            //m1.Sort();

            //insert at place
            m1.Insert(2, "ad");
            string x = "";
            foreach (string person in m1)
            {
                x += person + "\n";
            }

            Console.WriteLine(x);

            m1.Remove("ad");
            if (m1.Contains("anand"))
            {
                Console.WriteLine("found");
            }
            else
            {
                Console.WriteLine("not found");
            }

            Console.ReadKey();
        }

    }
}
