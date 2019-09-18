using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testRepository2.Interfaces;
using testRepository2.Models;

namespace testRepository2.Repositories
{
    public class NotebookRepository : Repository<Notebook>, INotebookRepository
    {
        private readonly XContext _xContext;

        public NotebookRepository(XContext xContext):base(xContext)
        {
            _xContext = xContext;
        }

        public IEnumerable GetSomeData()
        {
            return _xContext.Notebooks.Where(a => a.Id == 2);
        }
    }
}
