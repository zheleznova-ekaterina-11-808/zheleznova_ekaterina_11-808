using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Козла пустили в квадратный огород и привязали к колышку. Колышек воткнули точно в центре огорода. 
            //Козёл ест всё, до чего дотянется, не перелезая через забор огорода и не разрывая веревку. 
            //Какая площадь огорода будет объедена? Даны длина веревки и размеры огорода.

            Console.Write("Storona kvadrata = ");
            string A = Console.ReadLine();
            Console.Write("Radius verevki = ");
            string R = Console.ReadLine();
            double a = double.Parse(A);
            double r = double.Parse(R);

            //Если радиус окружности меньше или равен половине стороны квадрата.

            if (r <= a/2)
            {
                double S = r * r * Math.PI;
                Console.WriteLine(S);
            }

            // Если радиус окружности больше или равен половине диагонали квадрата.

            if (r >= a/(Math.Sqrt(2)))
            {
                double S = a * a;
                Console.WriteLine(S);
            }

            // Если радиус окружности больше половины стороны квадрата, но меньше половины его диагонали.

            if ((r > a/2) & (r < a/(Math.Sqrt(2))))
            {
                //Находим площадь треугольника внутри сектора

                double S1 = a / 2 * (Math.Sqrt((r * r) - (a * a) / 4));
                double cos = ((a * a) / (r * r)) / 2 - 1;
                double b = Math.Acos(cos);

                //Находим площадь всего сектора.

                double S2 = (Math.PI * r * r * b * 57.2958) / 360;

                //Вычитаем из площади сектора площадь треугольника. Таким образом мы находим площадь сегмента. Вычитаем из площади всего круга площадь четырех сегментов.

                double S = Math.PI*r*r - 4*(S2 - S1);
                Console.WriteLine(S);
            }
            Console.ReadLine();
        }
    }
}
