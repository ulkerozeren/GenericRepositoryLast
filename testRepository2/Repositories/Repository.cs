using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testRepository2.Interfaces;

namespace testRepository2.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly XContext _xContext;

        public Repository(XContext xContext)
        {
            _xContext = xContext;
        }
        public void Add(T model)
        {
            _xContext.Set<T>().Add(model);
            _xContext.SaveChanges();
        }

        public T Delete(int id)
        {
            var model= _xContext.Set<T>().Find(id);
            _xContext.Set<T>().Remove(model);
            _xContext.SaveChanges();
            return model;
        }

        public T Update(T model)
        {
            _xContext.Set<T>().Update(model);
            _xContext.SaveChanges();
            return model;
        }
    }
}
