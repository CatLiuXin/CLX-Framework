using CLX.Extensions.Helper;
using System;
using System.Reflection;

namespace CLX
{
    public class Singleton<T> where T:Singleton<T>
    {
        private static T instance=null;
        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    var flags = BindingFlags.NonPublic | BindingFlags.CreateInstance | BindingFlags.Instance;
                    instance = typeof(T).InvokeMember(null, flags, null, null,null) as T;
                    if (instance == null) throw new NullReferenceException("未能找到指定构造函数");
                }
                return instance;
            }
        }
        protected Singleton()
        {
        }
    }
}
