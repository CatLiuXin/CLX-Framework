using CLX.Extensions.Collections;
using CLX.Extensions.Generic;
using System;

namespace _3.List_Init_and_Do
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[100];
            int[] nums2 = new int[5];
            int res = 0;
            Random r = new Random(DateTime.Now.Millisecond);

            /// ResetBy 示例代码
            nums.ResetBy(() => r.Next(0, 99))
                .Do(() => Console.WriteLine("Randoms:"))
                .ForEach(v => { Console.Write(v + " "); });

            nums2.ResetBy(id => id * id)
                .Do(() => Console.WriteLine("\nNext:"))
                .ForEach(v => Console.Write(v + " "));

            Console.WriteLine("\nResult:" + res);
            Console.ReadKey();
        }
    }
}
