using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    //Задача 2
    //Сандин М.С.
    //Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); где m — масса тела в
    //    килограммах, h — рост в метрах.
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ваш вес?");
            string mass = Console.ReadLine();

            double m = Convert.ToDouble(mass);
            Console.WriteLine("Ваш рост?");

            string height = Console.ReadLine();
            double h = Convert.ToDouble(height);

            double i = m / (h*h);
            Console.WriteLine("Индекс массы тела: " + i);

            Console.ReadKey();

        }
    }
}
