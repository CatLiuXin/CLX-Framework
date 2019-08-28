using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLX
{
    public interface IObserver<in T>
    {
        void OnComplete();
        void OnError();
        void OnNext(T value);
    }
}
