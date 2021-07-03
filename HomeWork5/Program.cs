using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    // Задача 5     
    //Сандин М.С.        
    //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
    //б) * Сделать задание, только вывод организовать в центре экрана.
    //в) ** Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).
    class Program
    {
        #region метод для пункта (В)
        static string Print (string n, string s, string c, int x, int y)
        {
            Console.SetCursorPosition(x,y);
            string r = ("Ваши данные: " + n + " " + s + "Из города: " + c);
            return r;

        }
        #endregion
        static void Main(string[] args)
        {

            #region (a)
            /*Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Ваша фамилия?");
            string surname = Console.ReadLine();
            Console.WriteLine("В каком городе вы проживаете?");
            string city = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Ваши данные: " + name + " " + surname + "\nИз города: " + city);
            Console.ReadKey();*/
            #endregion

            #region (б)
            //Console.WriteLine("Как вас зовут?");
            //string name = Console.ReadLine();
            //Console.WriteLine("Ваша фамилия?");
            //string surname = Console.ReadLine();
            //Console.WriteLine("В каком городе вы проживаете?");
            //string city = Console.ReadLine();

            //Console.Clear();
            //Console.SetCursorPosition(45,15);
            //Console.WriteLine("Ваши данные: " + name + " " + surname + " из города: " + city);
            //Console.ReadKey();
            #endregion

            #region (в)
            int x = 45;
            int y = 15;
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Ваша фамилия?");
            string surname = Console.ReadLine();
            Console.WriteLine("В каком городе вы проживаете?");
            string city = Console.ReadLine();

            Console.Clear();

            Console.WriteLine( Print(name, surname, city, x, y) );
            Console.ReadKey();

            #endregion

        }
    }
}
