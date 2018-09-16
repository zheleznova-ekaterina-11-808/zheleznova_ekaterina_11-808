using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._09_expr3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задано время Н часов (ровно). Необходимо вычислить угол в градусах между часовой и минутной стрелками.

            Console.Write("The time is ");
            string H = Console.ReadLine();
            int time = int.Parse(H);
            int angle = (time % 12) * 30;
            if (angle > 180)
            { angle = 360 - angle; }
            Console.WriteLine("The angle between two arrows is {0}", angle);
            Console.ReadLine();
        }
    }
}
