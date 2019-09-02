# CLX-Framework

一个正在自行搭建的简单C#框架

### 目录结构

使用 `Visual Studio` 打开本框架工程后您将看到如下结构：

![Content.png](https://github.com/CatLiuXin/Pics/blob/master/CLX%20Framework/ReadMe/Content.png?raw=true)



`Samples 文件夹：` 用于存放代码的示例，将文件夹内的项目设置为启动项目后运行即可看到效果。  

`Study 文件夹：` 用于存放一些学习上学到的一些知识点的示例代码。  

`CLX Framework 项目：` 框架的核心项目。  

`CLX Framework/Core 文件夹：` 用于存放框架中的核心功能代码。  

`CLX Framework/Extensions 文件夹：` 用于放置框架中的拓展方法。  

`CLX Framework/Note 文件夹：` 用于存放部分读书笔记。  

`CLX Framework/ToolClass 文件夹：` 用于存放框架内的工具类。  

### 框架代码示例

```csharp
/// Hello World
"Hello World".Display();

/// 迭代器 Hello World
char[] str = new []{'H','e','l','l','o',' ','W','o','r','l','d'};
str.Display("");

/// 链式打印1~5的所有数字
1.To(5).ForEach(v=>v.Display());

/// Dictionary 拓展方法模拟简易计数器演示
var counter = new Dictionary<T,int>();
IEnumerable<T> msg;
msg.ForEach(v=>counter.AddOrReplace(v,1,num=>num+1));

/// 显示测试函数调用时间
Action action = ()=>{1.To(10000).ForEach(v=>v.Display());};
action.TimeCost().Display();

/// 消息通知机制
Announcer<int> announcer = new Announcer<int>();
CLX.IObserver<int>[] obs = new[] {
    Observer.Create<int>(v=>("v:"+v).Display(),()=>{ "v Complete".Display(); }),
    Observer.Create<int>(v=>("v*v:"+v*v).Display(),()=>{ "v*v Complete".Display(); })
}
obs.ForEach(o=>announcer.Subscribe(o));
1.To(5).ForEach(announcer.Announce);

/// 创建单例类
public class CLXSingleton:Singleton<CLXSingleton>

/// 对象池
IPool<int> pool = new ObjectPool<int>(factory,initNumber,onRecycle,onReset);
pool.Recycle(6);
var num = pool.Allocate();

/// 以上基于 CLX Framework v0.1.1
```



### 项目文档

头上有尖嘴，

身上有翅膀。

谁也不知道，

它有多少秘密。

我是一只小鸽子，

我就喜欢咕咕咕。

就要咕咕咕，嘿~

就要咕咕咕，嘿~

就要~咕咕咕~
