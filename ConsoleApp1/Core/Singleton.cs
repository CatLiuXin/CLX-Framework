using System;
using System.Reflection;

namespace CLX
{
    public class Singleton<T> where T:Singleton<T>
    {
        private Singleton<T> instance=null;
        public Singleton<T> Instance
        {
            get
            {
                if (instance == null)
                {
                    var flags = BindingFlags.NonPublic | BindingFlags.CreateInstance | BindingFlags.Instance;
                    instance = typeof(Singleton<T>).InvokeMember(null, flags, null, null,null) as Singleton<T>;
                    if (instance == null) throw new NullReferenceException("未能找到指定构造函数");
                }
                return instance;
            }
        }
        private Singleton()
        {

        }
    }
}
