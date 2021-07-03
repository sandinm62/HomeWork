using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    // задача 1     
    // Сандин М.С.
    // Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
    //а) используя склеивание;
    //б) используя форматированный вывод;
    //в) используя вывод со знаком $.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Ваша фамилия?");
            string surname = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            string years = Console.ReadLine();
            Console.WriteLine("Ваш вес?");
            string mass = Console.ReadLine();
            Console.WriteLine("Ваш рост?");
            string height = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Ваши данные:" + "\n*Фамилия: " + surname + "\n*Имя: " + name + "\n*Возраст: " + years + "\n*Масса: " + mass + "\n*Рост: " + height);
            Console.WriteLine("Ваши данные: {1} {0}, возраст {2}, масса {3}, рост {4}",name, surname,years,mass,height);
            Console.WriteLine($"Ваши данные: {surname} {name}, возраст {years}, масса {mass}, рост {height}");

            Console.WriteLine("Нажмите на любую клавишу для завершения");
            Console.ReadKey();
        }
    }
}
