using System.Collections.Generic;
using CLX.Extensions.Helper;
using CLX.Extensions.Test;
using CLX.Extensions.Collections;
using CLX.Extensions.Raws;
using CLX.Extensions.Generic;
using CLX;
using System.Linq;

namespace CLX_0._1._2_Samples.Samples
{
    class _3_MaxHeap_MinHeap_Example
    {
        public static void Test()
        {
            "MaxHeap MinHeap Example".Test(() =>
            {
                /// 打乱1~5
                IList<int> list = 1.To(5).ToList().Shuffle();
                MaxHeap<int> maxHeap = new MaxHeap<int>(list);
                MinHeap<int> minHeap = new MinHeap<int>(list);
                "Max Heap:".Display();
                1.To(5).ForEach(_ => { maxHeap.RemoveDominating().Display(); });
                "Min Heap:".Display();
                1.To(5).ForEach(_ => { minHeap.RemoveDominating().Display(); });
            });
        }
    }
}
