using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLX
{
    public interface IObserable<T>
    {
        IDisposable Subscribe(IObserver<T> observer);
    }
}
