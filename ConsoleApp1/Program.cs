using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using CLX.Extensions.Generic;
using CLX.Extensions.Helper;
using CLX.Extensions.Collections;
using CLX.ToolClass.Common;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {

        public static void Main()
        {
            var ints = new[] { 1, 2, 3, 4, 5, 6, 6, 6, 7, 8, 1, 5, 4, 3, 3, 2 };
            ints.Sort().Display(" ");

            Console.ReadKey();
        }
        
    }
}
