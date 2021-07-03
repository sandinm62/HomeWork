using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    //Задача 3
    //Сандин М.С.
    //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
    //б) * Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
    class Program
    {
        static double calculation(double a1, double b1, double a2, double b2 )
        {
            double r = Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2));
            
            return r;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение х1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение у1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение х2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение у2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            #region (a)
            /*  double r = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2));
              Console.WriteLine("Растояние между точками равно {0:f2}",r);
            */
            #endregion

            #region (б)
            Console.Clear();
            Console.WriteLine("Растояние между точками равно {0:f2}", calculation(x1,y1,x2,y2));
            #endregion


            Console.ReadKey();
        }
    }
}
