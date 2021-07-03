using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    //Задача 4
    //Сандин М.С.
    /* Написать программу обмена значениями двух переменных:
     а) с использованием третьей переменной;
     б) * без использования третьей переменной.
     */
    class Program
    {
        static void Main(string[] args)
        {

            #region инструкци я для выполнения программы под (а)
            /*
            Console.WriteLine("Введите значение а");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение b");
            int b = Convert.ToInt32(Console.ReadLine());
            int c; 

            c = a;
            a = b;
            b = c;
            */
            #endregion


            #region инструкци я для выполнения программы под (б)
            Console.WriteLine("Введите значение а");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение b");
            int b = Convert.ToInt32(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("a = " + a + "\nb = " + b);
            Console.ReadKey();
            #endregion
        }
    }
}
