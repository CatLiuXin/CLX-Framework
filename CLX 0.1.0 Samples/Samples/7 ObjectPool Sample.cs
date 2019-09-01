using System;
using CLX;
using CLX.Extensions.Test;
using CLX.Extensions.Helper;
using CLX.Extensions.Raws;
using CLX.Extensions.Generic;

namespace CLX_0._1._0_Samples.Samples
{
    class _7_ObjectPool_Sample
    {
        public static void Test()
        {
            "ObjectPool Example".Test(() =>
            {
                Random r = new Random(Guid.NewGuid().GetHashCode());
                /// 创建一个当前大小为5的对象池
                IPool<int> pool = new ObjectPool<int>(
                    factory: () =>
                    {
                        var v = r.Next(0, 10);
                        (v + " insert to pool").Display();
                        return v;
                    },
                    initNumber: 5,
                    onRecycle: v => (v + " recycle to pool").Display(),
                    onReset: v => (v + " reset").Display()
                    );
                /// 对当前的对象池中每个对象都获取、回收一次
                /// 之所以可以这样是因为ObjectPool的内部原理是用Queue做的对象池容器
                1.To(5).ForEach(_ =>
                {
                    var v = pool.Allocate();
                    pool.Recycle(v);
                });
                /// Count属性的检验
                ("Count:" + pool.Count).Display();
                pool.Allocate();
                ("Count:" + pool.Count).Display();
                pool.Recycle(888);
                ("Count:" + pool.Count).Display();
            });
        }
    }
}
