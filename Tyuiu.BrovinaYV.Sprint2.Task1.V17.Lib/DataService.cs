using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BrovinaYV.Sprint2.Task1.V17.Lib
{// (==, !=, <, >, <=, >=, последовательность можно чередовать, но использовать один раз в выражении) и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться),
 // а также арифметических выражений, которая вернет логическую последовательность(массив): (True, False, True, True, True, False), при a = 135, b = 123, c = 455, d = 321
    public class DataService : ISprint2Task1V17
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] =(a>b) | (c<d) ; //t
            res[1] = (a<b) & (c>d);//f
            res[2] = (a > b) || (c < d);//t
            res[3] = (a < b+13) && (c != d); //t
            res[4] = !(res[1]) ; //t
            res[5] = (a>b)^(c>=d) ; //f
            
            return res;

        }
    }
}
