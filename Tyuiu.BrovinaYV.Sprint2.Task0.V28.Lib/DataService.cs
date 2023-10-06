using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BrovinaYV.Sprint2.Task0.V28.Lib
{
    public class DataService : ISprint2Task0V28
    {
        //  (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться)
        // и арифметических выражений, которая вернет логическую последовательность(массив):
        // (False, False, False, False, False, False), при x = 111, y = 735
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            
            res[0] = x == y;
            res[1] = x + 624 != y;
            res[2] = x+624 < y;
            res[3] = x > y;
            res[4] = x+625 <= y;
            res[5] = x >= y;

            return res;
        }
    }
}
