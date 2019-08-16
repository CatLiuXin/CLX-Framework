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
            /// Github上传测试
            Action action = () =>
            {
                for (int i = 0; i < 1000; i++) i.Display();
            };
            action.TimeCost().Display();

            Console.ReadKey();
        }
    }
}
