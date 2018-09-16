using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._09_expr2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задается натуральное трехзначное число. Необходимо развернуть его.

            Console.Write("Trexznachnoe chislo = ");
            string chislo = Console.ReadLine();
            int b = int.Parse(chislo);
            int a1 = b % 10;
            int a2 = (b / 10) % 10;
            int a3 = b / 100;
            b = 100 * a1 + 10 * a2 + a3;
            Console.WriteLine("Perevernutoe chislo = {0}", b);
            Console.ReadLine();
        }
    }
}
