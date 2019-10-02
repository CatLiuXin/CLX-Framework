using System;
using System.Collections.Generic;
using System.Text;

namespace CLRViaCS._6_Const_and_Readonly
{
    public class ConstAndReadonly
    {
        /// <summary>
        /// readonly 修饰的字段只能在构造器里对其进行赋值
        /// 除此之外，如果修饰的字段是引用类型
        /// 那么不可改变的是引用而不是引用的对象
        /// </summary>
        readonly int ro = 1;

        /// <summary>
        /// const 修饰的字段不可以进行改动
        /// 如果别的程序集引用这个程序集里的const字段
        /// 那么并不会去加载那个程序集
        /// 而只是将这个const值读入并替换引用之处
        /// 这样可以提高一定的性能（少引入了一些程序集）
        /// 
        /// 不过这样所带来的问题是
        /// 如果后期改变这个const值时
        /// 应用程序要获得这个改变后的值
        /// 必须要重新编译
        /// 如果没有重新编译，那么应用的会是原来的值
        /// 
        /// 如果需要避免上面的情况的话，请使用static readonly
        /// 尽管会有一点性能上的损失
        /// </summary>
        const int co = 2;
    }
}
