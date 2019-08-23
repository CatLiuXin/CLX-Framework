using CLX.Extensions.Collections;
using CLX.Extensions.Helper;
using CLX.Extensions.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLX_0._1._0_Samples
{
    class _1_CombineToString_Example
    {
        public static void Test()
        {
            "CombineToString".Test(() =>
            {
                string text = "asbfnejkfb";
                ("string Before Sort:" + text).Display();
                ("string After  Sort:" + text.ToCharArray().Sorted().CombineToString()).Display();

                List<char> list = new List<char>(text);
                ("list Before Sort:" + list.CombineToString()).Display();
                list.Sort();
                ("list After  Sort:" + list.CombineToString()).Display();
            });
        }
    }
}
