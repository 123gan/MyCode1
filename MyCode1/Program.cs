using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MyCode1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> saveNum = new List<int>();
            saveNum.Add(292);
            saveNum.Add(2);
            saveNum.Add(34);
            foreach(int num in saveNum)
            {
                WriteLine(num);
            }
            WriteLine("--------默认排序后----------");
            saveNum.Sort();
            foreach (int num in saveNum)
            {
                WriteLine(num);
            }
            WriteLine("-------自定义排序函数后---------------");
            Comparison<int> sorter = new Comparison<int>(SortForInt.compare);
            saveNum.Sort(sorter);
            foreach (int num in saveNum)
            {
                WriteLine(num);
            }
            ReadLine();
        }
    }

    public static class SortForInt
    {
        public static int compare(int x, int y)
        {
            if(x > y)
            {
                return -1;
            }
            else if(x < y)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
