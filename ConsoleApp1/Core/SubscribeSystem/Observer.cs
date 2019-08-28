using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLX
{
    public class Observer<T> : IObserver<T>
    {
        private Action onComplete;
        private Action<Exception> onError;
        private Action<T> onNext;
        public void OnComplete()
        {
            onComplete();
        }

        public void OnError(Exception ex)
        {
            onError(ex);
        }

        public void OnNext(T value)
        {
            onNext(value);
        }
    }
}
