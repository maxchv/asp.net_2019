using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson06.Repository
{
    public interface IRepository<T, ID>
    {
        void Save(T data);
        void Delete(T data);
        IEnumerable<T> FindAll();
        T FindById(ID id);
    }
}
