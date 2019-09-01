using CLX;
using CLX.Extensions.Test;
using CLX.Extensions.Helper;
using CLX.Extensions.Generic;
using CLX.Extensions.Raws;

namespace CLX_0._1._0_Samples.Samples
{
    class _4_SubscribeSystem_Sample
    {
        public static void Test()
        {
            "SubscribeSystem Sample".Test(() =>
            {
                Announcer<int> announcer = new Announcer<int>();
                CLX.IObserver<int>[] obs = new[] {
                    Observer.Create<int>(v=>("v:"+v).Display(),()=>{ "v Complete".Display(); }),
                    Observer.Create<int>(v=>("v*v:"+v*v).Display(),()=>{ "v*v Complete".Display(); })
                };
                obs.ForEach(o=>announcer.Subscribe(o));
                1.To(5).ForEach(announcer.Announce);
                announcer.OnComplete();
            });
        }
    }
}
