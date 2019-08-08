using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace out_and_in_keyword
{
    class Program
    {
        /// <summary>
        /// 如果接口的泛型T用in修饰
        /// 则T是作为接口的方法的参数的类型
        /// 所以Interface<Son> son = new Interface<Parent>成立
        /// 因为Son接口传进来的肯定是Son类型或其子类的对象
        /// 故都可以用来当Parent类的对象来使用
        /// out则反之
        /// </summary>
        public class Parent { }
        public class Son : Parent { }
        interface MyInterface<in T> { }
        public class C : MyInterface<Parent> { }
        public static void Main()
        {
            MyInterface<Son> my = new C();
            Console.ReadKey();
        }
    }
}
