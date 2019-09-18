using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testRepository2.Interfaces;
using testRepository2.Models;

namespace testRepository2.Repositories
{
    public class PenRepository: Repository<Pen>, IPenRepository
    {
        private readonly XContext _xContext;

        public PenRepository(XContext xContext):base(xContext)
        {
            _xContext = xContext;
        }
    }
}
