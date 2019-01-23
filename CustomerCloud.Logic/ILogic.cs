using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCloud.Logic
{
    interface ILogic<T>
    {
        void Create(T item);
        T Read(T item);
        void Update(T item);
        void Delete(T item);
    }
}
