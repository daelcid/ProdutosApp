using ProdutoApp.Domain.Contracts.Repositories;
using ProdutoApp.Domain.Models.Entities;
using ProdutoApp.Infra.Data.Contexts;

namespace ProdutoApp.Infra.Data.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public Produto? GetById(Guid id)
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Set<Produto>()
                    .FirstOrDefault(p => p.Id == id);
            }
        }

        public Produto? GetByName(string nome)
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Set<Produto>()
                    .FirstOrDefault(p => p.Nome == nome);
            }
        }
    }
}
