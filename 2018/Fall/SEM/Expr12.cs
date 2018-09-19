using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Самолёт должен набрать высоту h метров в течение первых t секунд полёта и удерживать её в течение всего полёта. 
            //Разрешён набор высоты со скоростью не более чем v метров в секунду. До полного набора высоты запрещено снижаться. 
            //Известно, что уши заложены в те и только те моменты времени, когда самолёт поднимается со скоростью более x метров в секунду. 
            //Посчитайте минимальное и максимальное возможное время, в течение которого у пассажиров будут заложены уши. 
            //Считайте, что самолёт способен изменять скорость мгновенно.

            Console.Write("Hight = ");
            string h1 = Console.ReadLine();
            Console.Write("Time = ");
            string t1 = Console.ReadLine();
            Console.Write("Max speed = ");
            string v1 = Console.ReadLine();
            Console.Write("Max comfortable speed = ");
            string x1 = Console.ReadLine();
            int h = int.Parse(h1);
            int t = int.Parse(t1);
            int v = int.Parse(v1);
            int x = int.Parse(x1);

            //Минимальное время, в течение которого будут заложены уши. 

            double minTime;
            if ((h - x * t) <= 0) minTime = 0;
            else minTime = (h - t * x) / (v - x);
            Console.WriteLine("Min Time = {0}", minTime);

            //Максимальное время, в течение которого будут заложены уши.

            double maxTime;
            if ((h / t) > x) maxTime = t;
            else maxTime = ((h - t * x - t) / x);
            Console.WriteLine("Max Time = {0}", maxTime);
            Console.ReadLine();
        }
    }
}
