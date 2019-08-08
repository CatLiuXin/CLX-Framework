using CLX.Extensions.Generic;
using CLX.Extensions.Raws;
using CLX.Extensions.Collections;
using System;
using System.Collections.Generic;
using System.Linq;


namespace _1.GenericCollections_Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>() { 1, 2, 3 };
            Queue<int> q = new Queue<int>() { 4, 5, 6 };
            Console.WriteLine(s.Last());

            Console.WriteLine("Foreach:");
            s.ForEach(v => { Console.WriteLine(v); });

            Console.WriteLine("IsNull:");
            Console.WriteLine(s.IsEmpty());
            s.Clear();
            Console.WriteLine(s.IsEmpty());

            string str = "123456";
            Console.WriteLine(str.ToInt());

            Console.WriteLine(5.IsBetweenDefault(4, 6));
            Console.WriteLine('b'.IsBetweenDefault('a', 'c'));
            Console.WriteLine('b'.IsBetween('a', 'c', (x, y) => y - x));

            Console.ReadKey();
        }
    }
}
