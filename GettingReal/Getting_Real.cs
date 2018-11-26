using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vælg punkt mellem 1-4");
            int switchCase = Convert.ToInt32(Console.ReadLine());
            switch (switchCase)
            {
                case 1:
                    Console.WriteLine("1. Registrér timer");
                     

                    break;

                case 2:
                    Console.WriteLine("2. Se afsluttede vagter for denne måned");

                    break;
            }
        }
    }
}
