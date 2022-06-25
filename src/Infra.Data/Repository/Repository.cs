using Domain.Contracts;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity:class
    {
        private readonly UniversityDbContext _context;
        private DbSet<TEntity> dbSet => _context.Set<TEntity>();

        public Repository(UniversityDbContext context)
        {
            _context = context;
        }

        public void Delete(object id)
        {
            var entity = GetById(id);
            if (entity==null)
                throw new ArgumentException("No entity");
            _context.Remove(entity);
        }

        public void Delete(TEntity entity)
        {
            _context.Remove(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return dbSet.AsEnumerable();
        }

        public TEntity GetById(object id)
        {
            return dbSet.Find(id);
        }

        public void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public void Update(TEntity entity)
        {
            dbSet.Update(entity);
        }
    }
}