using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = TaskOne(new int[] { 1, 5, 8, 34, 23, 18, 5, 35, 91, 2 });
            foreach (var e in array)
                Console.WriteLine(e);
            Console.ReadKey();
        }

        static int[] TaskOne(int[] array)
        {
            var arr1 = array
                .Select((item, index) => new { Item = item, Index = index })
                .Where(n => n.Index % 3 == 1)
                .Select(n => n.Item * 2);

            var arr2 = array
                .Select((item, index) => new { Item = item, Index = index })
                .Where(c => c.Index % 3 == 2)
                .Select(c => c.Item);

            return arr1.Concat(arr2).ToArray();
            //Не смогла сохранить порядок следования элементов
        }
    }
}
