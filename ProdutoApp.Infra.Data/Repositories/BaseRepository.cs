using ProdutoApp.Domain.Contracts.Repositories;
using ProdutoApp.Infra.Data.Contexts;

namespace ProdutoApp.Infra.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        public void Add(TEntity entity)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Set<TEntity>().Add(entity);
                dataContext.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Set<TEntity>().Remove(entity);
                dataContext.SaveChanges();
            }
        }

        public List<TEntity> GetAll()
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Set<TEntity>()
                    .ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Set<TEntity>().Update(entity);
                dataContext.SaveChanges();
            }
        }
    }
}
