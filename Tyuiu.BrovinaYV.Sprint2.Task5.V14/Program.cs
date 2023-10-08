using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BrovinaYV.Sprint2.Task5.V14.Lib;

namespace Tyuiu.BrovinaYV.Sprint2.Task5.V14
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
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнила Бровина Юлия Викторовна | АСОиУБ-23-2                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Определить, каким днем недели является k-й день не високосного года,    *");
            Console.WriteLine("* в котором 1 января d-й день недели                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите k-ый день: ");
            int k = Convert.ToInt32(Console.ReadLine());
            string res;
            Console.WriteLine("Введите d-ый день: ");
            int d = Convert.ToInt32(Console.ReadLine());
            if ((k<1)||(k>365))
            { res = "Введеное значение некорректно, введите значени от 1 до 365"; }
            else { res = "День недели: " + ds.FindDayName(k,d);
            }
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine( res);
            Console.ReadKey();
        }
    }
}
