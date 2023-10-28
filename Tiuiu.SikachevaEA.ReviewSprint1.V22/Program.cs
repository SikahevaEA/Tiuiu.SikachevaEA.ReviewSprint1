using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiuiu.SikachevaEA.ReviewSprint1.V22.Lib;

namespace Tiuiu.SikachevaEA.ReviewSprint1.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            double x, y;

            Console.WriteLine("Введите значение x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение y: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Значение выражение равно: " + ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
