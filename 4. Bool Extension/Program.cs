using CLX.Extensions.Helper;
using CLX.Extensions.Raws;
using System;

namespace _4.Bool_Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            bool T = true, F = false;
            T.Then(T.Display).Else(T.Display);
            F.Then(F.Display).Else(F.Display);
            Console.ReadKey();
        }
    }
}
