using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._09_expr4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Необходимо найти количество чисел меньших N, которые делятся на x или y.

            Console.Write("Chislo N ");
            string N = Console.ReadLine();
            Console.Write("Chislo x ");
            string x = Console.ReadLine();
            Console.Write("Chislo y ");
            string y = Console.ReadLine();
            int N1 = int.Parse(N);
            int x1 = int.Parse(x);
            int y1 = int.Parse(y);
            int kolvo = (N1 - 1) / x1 + (N1 - 1) / y1 - (N1 - 1) / (x1 * y1);
            Console.WriteLine("Kolvo chisel = {0}", kolvo);
            Console.ReadLine();
        }
    }
}
