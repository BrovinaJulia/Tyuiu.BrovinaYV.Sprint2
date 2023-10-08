using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BrovinaYV.Sprint2.Task5.V14.Lib
{
    public class DataService : ISprint2Task5V14
    {
        public string FindDayName(int k, int d)
        {
            int day = (k - 1) % 7;

            int FindDayName = (day + d - 1) % 7 + 1;

           // int FindDayName = (d + k - 2) % 7 + 1;
            string res;

            switch (FindDayName)
            {
                case 1:
                    res = "Понедельник";
                    break;
                case 2:
                    res = "Вторник";
                    break;
                case 3:
                    res = "Среда";
                    break;
                case 4:
                    res = "Четверг";
                    break;
                case 5:
                    res = "Пятница";
                    break;
                case 6:
                    res = "Суббота";
                    break;
                case 7:
                    res = "Воскресенье";
                    break;
                default:
                    throw new ArgumentException($"Введите чисор от 1 до 365. Значение {k}");
            }
            return res;
            
        }
    }
}
