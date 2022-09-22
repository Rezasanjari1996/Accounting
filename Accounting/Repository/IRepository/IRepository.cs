using Accounting.Models;
using System.Linq.Expressions;

namespace Accounting.Repository.IRepository
{
    public interface IRepository<TEntity> where TEntity:Entity {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        //Add
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        //Remove
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
