using System.Collections.Generic;
using CLX.Extensions.Test;
using CLX.Extensions.Helper;
using CLX.Extensions.Raws;
using CLX.Extensions.Generic;
using CLX;

namespace CLX_0._1._2_Samples.Samples
{
    class _1_EventCollection_Example
    {
        public static void Test()
        {
            //Dictionary<int, bool> dict = new Dictionary<int, bool>();

            //var co = new EventCollection<KeyValuePair<int, bool>>(dict);

            //co.Add(new KeyValuePair<int, bool>(1, false));
            //KeyValuePair<int, bool>[] test = new KeyValuePair<int, bool>[8];
            //co.CopyTo(test, 0);
            //test[0].Display();
            //"hello".Display();
            "EventCollection Example".Test(() =>
            {
                EventCollection<int> colletion = new EventCollection<int>(new List<int>(),
                        v => ("Add:" + v).Display(),
                        v => ("Remove:" + v).Display(),
                        v => ("Clear:" + v).Display());
                1.To(5).ForEach(colletion.Add);
                1.To(3).ForEach(v => colletion.Remove(v));
                colletion.Clear();
            });
        }
    }
}
