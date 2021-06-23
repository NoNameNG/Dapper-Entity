using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IRepository<T> where T: IDomainObject, new()
    {
        IEnumerable<T> GetAll();

        void Create(T obj);

        void Update(T obj);

        void Delete(int id);

        void Save();

    }
}
