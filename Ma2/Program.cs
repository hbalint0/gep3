using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tanulo diak1 = new Tanulo();
            Console.WriteLine(diak1.szulev);

            if (diak1.szulev == 2010)
            {
                Console.WriteLine("OK");
            }

            Console.ReadKey();
        }
    }
}
