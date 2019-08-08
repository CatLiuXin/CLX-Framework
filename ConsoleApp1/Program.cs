using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using CLX.Extensions.Generic;
using CLX.Extensions.Helper;
using CLX.Extensions.Collections;
using CLX.ToolClass.Common;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            int[] nums = new[] { 1, 2, 3, 5 };
            nums.Shuffle().ForEach(v => v.Display());
            Console.ReadKey();
        }
        
    }
}
