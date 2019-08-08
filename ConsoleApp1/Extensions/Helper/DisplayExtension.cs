using CLX.ToolClass.Common;
using System.Linq;
using System.Collections.Generic;
using CLX.Extensions.Raws;
using CLX.Extensions.Generic;
using System;

namespace CLX.Extensions.Helper
{
    public static class DisplayExtension
    {
        private static Action<string> logAction;

        static DisplayExtension()
        {
            logAction = Console.WriteLine;
        }

        /// <summary>
        /// 转变输出的方式
        /// </summary>
        public static void ChangeLogActionTo(Action<string> logAction)
        {
            DisplayExtension.logAction = logAction;
        }

        public static void Display(this string str)
        {
            logAction(str);
        }

        public static void Display<T>(this IEnumerable<T> list,string separator="\t")
        {
            list.Select(item => item.ToString()).JoinWith(separator).Display();
        }

        public static void Display(this object obj)
        {
            Display(obj.ToString());
        }
    }
}
