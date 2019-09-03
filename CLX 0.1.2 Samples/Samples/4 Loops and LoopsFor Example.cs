using System;
using System.Collections.Generic;
using System.Text;
using CLX.Extensions.Test;
using CLX.Extensions.Raws;
using CLX.Extensions.Helper;

namespace CLX_0._1._2_Samples.Samples
{
    class _4_Loops_and_LoopsFor_Example
    {
        public static void Test()
        {
            "Loops and LoopsFor Example".Test(() =>
            {
                Action action = () => "Hello World".Display();
                "LoopsFor:".Display();
                2.LoopsFor(action);
                "Loops:".Display();
                action.Loops(2);
            });
        }
    }
}
