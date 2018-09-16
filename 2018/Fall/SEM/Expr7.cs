using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Необходимо найти вектор, параллельный прямой. Перпендикулярный прямой. Прямая задана коэффициентами уравнения прямой.
            string k = Console.ReadLine();
            string b = Console.ReadLine();
            int k1 = int.Parse(k);
            int b1 = int.Parse(b);
            double k2 = Math.Pow(-k1,-1);
            Console.WriteLine("Parallelniy vektor (1;{0})", k1);
            Console.WriteLine("Perpendikulyarniy vektor (1;{0})", k2);
            Console.ReadLine();
        }
    }
}
