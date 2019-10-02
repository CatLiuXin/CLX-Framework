using System;

namespace CLRViaCS
{
    class Program
    {
        static void Main(string[] args)
        {
            /// chapter5
            /// dynamic 调用类的静态成员
            dynamic stringType = new _5_Dynamic.StaticMemberDynamicWrapper(typeof(String));
            var r = stringType.Concat("A", "B");

            Console.WriteLine(r);

            Console.ReadKey();
        }
    }
}
 