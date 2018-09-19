using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Найти сумму всех положительных чисел меньше 1000 кратных 3 или 5.
            //s3 - сумма всех чисел делящихся на 3.
            //s5 - сумма всех чисел делящихся на 5.
            //s15 - суммма всех чисел делящихся на 15.
            int s3 = ((3 + 999) * 332) / 2;
            int s5 = ((5 + 995) * 198) / 2;
            int s15 = ((15 + 990) * 65) / 2;
            int sum = s3 + s5 - s15;
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
