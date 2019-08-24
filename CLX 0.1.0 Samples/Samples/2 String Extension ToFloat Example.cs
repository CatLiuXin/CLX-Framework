using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLX.Extensions.Helper;
using CLX.Extensions.Raws;
using CLX.Extensions.Test;

namespace CLX_0._1._0_Samples.Samples
{
    class _2_String_Extension_ToFloat_Example
    {
        public static void Test()
        {
            string text = "13.5";
            string emptyText = "emptyText";

            "ToFloat".Test(() =>
            {
                "无参ToFloat:".Display();
                text.ToFloat().Display();

                "含默认值ToFloat:".Display();
                emptyText.ToFloat(4.5f).Display();

                "TryToFloat:".Display();
                float res;
                emptyText.TryToFloat(out res)
                    .Then(res.Display)
                    .Else((emptyText + " Can't change to float value!").Display);
            });
        }
    }
}
