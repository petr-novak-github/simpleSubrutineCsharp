using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSubrutineCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Vypis5kratText(5, "napis");
            Console.ReadLine();
        }

        static void Vypis5kratText(int max, string text)
        {
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine(text);
            }
        }

    }
}
