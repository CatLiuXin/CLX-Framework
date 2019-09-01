using System.Threading;
using CLX;
using CLX.Extensions.Helper;
using CLX.Extensions.Test;

namespace CLX_0._1._0_Samples.Samples
{
    class _6_Singleton_Example
    {
        public static void Test()
        {
            "Singleton Example".Test(() =>
            {
                /// 单例模式（懒汉模式）
                Thread.Sleep(1000);
                CLXSingleton singleton = CLXSingleton.Instance;
            });
        }

        private class CLXSingleton : Singleton<CLXSingleton>
        {
            private CLXSingleton()
            {
                "CLXSingleton Created".Display();
            }
        }
    }
}
