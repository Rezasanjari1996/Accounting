using Accounting.DAL;
using Accounting.Models;
using Accounting.Repository.IRepository;
using System.Linq.Expressions;

namespace Accounting.Repository
{
    public class Repository<TEntity> :IRepository<TEntity> where TEntity:Entity
    {
        protected readonly AppDbContext ContextDB;
        public Repository(AppDbContext context)
        {
            this.ContextDB = context;
        }

        public TEntity Get(int id)
        {
            return ContextDB.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return ContextDB.Set<TEntity>();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return ContextDB.Set<TEntity>().Where(predicate);
        }

        public void Add(TEntity entity)
        {
            ContextDB.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            ContextDB.Set<TEntity>().AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            ContextDB.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            ContextDB.Set<TEntity>().RemoveRange(entities);
        }
    }
}
