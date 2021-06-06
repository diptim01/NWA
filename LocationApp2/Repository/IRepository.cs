using LocationApp2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocationApp2.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();

        T GetSingle(long id);

        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
