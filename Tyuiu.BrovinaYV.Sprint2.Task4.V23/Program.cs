using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BrovinaYV.Sprint2.Task4.V23.Lib;

namespace Tyuiu.BrovinaYV.Sprint2.Task4.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Бровина Ю. В. | АСОиУБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Алгоритмы разветляющей структуры                                  *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнила Бровина Юлия Викторовна | АСОиУБ-23-2                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет значение с использование          *");
            Console.WriteLine("* тернарного оператора, где пользователь вводит значение x,y              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите значение переменной X: ");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение переменной Y: ");
            double y = Convert.ToInt32(Console.ReadLine());
            double res = ds.Calculate(x,y);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Значение функции = " + res);
            Console.ReadKey();
        }
    }
}
