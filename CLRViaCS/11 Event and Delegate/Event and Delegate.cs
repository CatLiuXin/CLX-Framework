using System;
using System.Collections.Generic;
using System.Text;

namespace CLRViaCS._11_Event_and_Delegate
{
    class Event_and_Delegate
    {
        delegate void TestDelegate();

        class Test1
        {
            public TestDelegate mTestDelegate;
            public Test1()
            {
                /// 普通的delegate实例的话，无论是在申明的类里
                /// 还是在类外，都可以对他进行 +=、-=、= 操作
                mTestDelegate = () => { Console.WriteLine("Test1.mTestDelegate"); };
            }

        }
        class Test2
        {
            public event TestDelegate mEventDelegate;
            public Test2()
            {
                /// 单纯用 event 修饰的委托，系统会自己生成Add和remove方法
                /// 并产生一个private的委托实例
                /// 因此只可以在声明的类里对其进行赋值
                /// 在类外只能 += 或者 -=
                mEventDelegate = () => { Console.WriteLine("Test2.mEventDelegate"); };
            }
        }

        class Test3
        {
            public event TestDelegate mEventDelegate
            {
                add { Console.WriteLine("Test3.mEventDelegate add"); }
                remove { Console.WriteLine("Test3.mEventDelegate remove"); }
            }

            public Test3()
            {
                /// 使用自己实现remove、add的事件
                /// 不能对其进行赋值操作，只能进行 +=、-= 来执行实现好的add、remove操作
                /// 另外，不能直接用事件对象调用注册好的委托
                /// 必须自己实现逻辑调用
                mEventDelegate += () => { Console.WriteLine("Test3.mEventDelegate"); };
            }
        }
    }
}
