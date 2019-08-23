using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using CLX.Extensions.Generic;
using CLX.Extensions.Helper;
using CLX.Extensions.Raws;
using CLX.Extensions.Collections;
using CLX.ToolClass.Common;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        public static void Test() => "Test".Display();

        public static void Main()
        {
            bool T = true, F = false;
            T.Then(T.Display).Else(T.Display);
            F.Then(F.Display).Else(F.Display);
            Test();
            Console.ReadKey();
        }
    }
}
