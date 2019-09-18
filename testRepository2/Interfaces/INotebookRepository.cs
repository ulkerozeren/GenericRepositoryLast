using System.Collections;
using testRepository2.Models;

namespace testRepository2.Interfaces
{
    public interface INotebookRepository: IRepository<Notebook>
    {
        IEnumerable GetSomeData();
    }
}
