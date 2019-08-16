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
            var values = new[] { 1, 5, 6, 7, 9, 9, 5, 4 };
            DisplayExtension.ChangeDefaultSeparatorTo("\t");
            (from value in values
             where value != 9
             select value).Display(" ");

            Console.ReadKey();
        }
    }
}
