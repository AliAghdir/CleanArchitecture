using Domain.Entities;

namespace Domain.Contracts
{
    public interface IRepository<TEntity> where TEntity:class
    {
         void Insert(TEntity entity);
         void Update(TEntity entity);
         void Delete(object id);
         void Delete(TEntity entity);

         TEntity GetById(object id);
         IEnumerable<TEntity> GetAll();
    }
}