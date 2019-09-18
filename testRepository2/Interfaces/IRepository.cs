using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testRepository2.Interfaces
{
    public interface IRepository<T> where T: class
    {
        void Add(T model);
        T Delete(int id);
        T Update(T model);
    }
}
