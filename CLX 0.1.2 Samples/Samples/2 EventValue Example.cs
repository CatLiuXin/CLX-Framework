using System;
using System.Collections.Generic;
using System.Text;
using CLX.Extensions.Helper;
using CLX.Extensions.Test;
using CLX.Extensions.Raws;
using CLX.Extensions.Generic;
using CLX;

namespace CLX_0._1._2_Samples.Samples
{
    class _2_EventValue_Example
    {
        public static void Test()
        {
            "EventValue Example".Test(() =>
            {
                EventValue<int> ev = new EventValue<int>(
                    initValue: 0,
                    onValueChange: (before, now) =>
                     {
                         ("Before Value:" + before).Display();
                         ("Now Value:" + now).Display();
                     });
                1.To(5).ForEach(v => { ev.Value = v; });
            });
        }
    }
}
