using CLX.Extensions.Generic;
using CLX.Extensions.Helper;
using CLX.Extensions.Raws;
using CLX.Extensions.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLX_0._1._0_Samples.Samples
{
    class _3_Int_Extension_To_Sample
    {
        public static void Test()
        {
            "Int To".Test(() =>
            {
                1.To(-1,-2).ForEach(v =>
                {
                    v.Display();
                });
            });
        }
    }
}
