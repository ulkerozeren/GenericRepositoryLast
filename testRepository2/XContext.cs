using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testRepository2.Models;

namespace testRepository2
{
    public class XContext: DbContext
    {
        public XContext(DbContextOptions<XContext> options): base(options)
        {

        }

        public DbSet<Pen> Pens { get; set; }
        public DbSet<Notebook> Notebooks { get; set; }
      }
}
