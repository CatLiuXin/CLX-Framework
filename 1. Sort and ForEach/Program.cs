using System;
using System.Linq;
using CLX.Extensions.Collections;
using CLX.Extensions.Generic;

namespace _1.Sort_and_ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            /// 输出去掉6以后再反序排序的所有数字
            int[] ints = new[] { 1, 6, 8, 6, 7, 6, 99, 6 };

            ints.Where(v => v != 6)
                .ToArray()
                .Sorted()
                .Reverse()
                .ForEach(v => Console.WriteLine(v));

            Console.WriteLine("Next:");
            ints.Swap(1, 2);
            ints.ForEach(v => Console.WriteLine(v));

            Console.WriteLine("Next:");
            ints.ResetByValue(5);
            ints.ForEach(v => Console.WriteLine(v));
            Console.ReadKey();
        }
    }
}
