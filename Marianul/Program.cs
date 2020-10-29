using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marianul
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            string line;
            line = Console.ReadLine();
            string[] numere = line.Split(' ');
            x = int.Parse(numere[0]);
            y = int.Parse(numere[1]);
            z = int.Parse(numere[2]);
            int a, b, c;
            a = z / (x * y);
            b = (z - a * (x * y)) / y;
            c = (z - a * (x * y)) - (b * y);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
