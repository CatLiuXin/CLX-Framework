using CLX.Extensions.Collections;
using CLX.Extensions.Generic;
using CLX.Extensions.Helper;
using CLX.Extensions.Test;
using System.Collections.Generic;

namespace CLX_0._1._0_Samples.Samples
{
    class _5_Dictionary_Extension_AddOrReplace_Sample
    {
        public static void Test()
        {
            /// 简易计数器
            "AddOrReplace Make Simple Counter".Test(() =>
            {
                string msg = "This is a Simple Sample";
                Dictionary<char, int> counter = new Dictionary<char, int>();
                msg.Display();
                msg.ForEach(ch => counter.AddOrReplace(ch, 1, v => v + 1));
                "Counter Result:".Display();
                counter.ForEach(pair => (pair.Key + ":" + pair.Value).Display());
            });
        }
    }
}
