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

            GetValues(0, 100).Count().Display();

            Console.ReadKey();
        }

        public static IEnumerable<int> GetValues(int beg,int count)
        {
            for(int i = 0; ; i++)
            {
                yield return beg + i;
            }
        }
    }
}
