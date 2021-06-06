using LocationApp2.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocationApp2.Repository
{
    public class Repository<T> : IRepository<T> where T: BaseEntity
    {
        private readonly DbContext dbContext;
        private DbSet<T> entities;
        public Repository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            entities = dbContext.Set<T>();
        }

        public void Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentException($"Cannot Delete null entity {entity}");

            entities.Remove(entity);


        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public T GetSingle(long id)
        {
           return entities.FirstOrDefault(entity => entity.Id == id);
        }

        public void Insert(T entity)
        {
            if (entity == null)
                throw new ArgumentException($"Cannot in sertnull entity {entity}");

            entities.Add(entity);
        }

        public void Update(T entity)
        {
            if (entity == null)
                throw new ArgumentException($"Cannot Update null entity {entity}");

            entities.Update(entity);
        }
    }
}
