using ProdutoApp.Domain.Contracts.Repositories;
using ProdutoApp.Domain.Models.Entities;
using ProdutoApp.Infra.Data.Contexts;

namespace ProdutoApp.Infra.Data.Repositories
{
    public class FornecedorRepository : BaseRepository<Fornecedor>, IFornecedorRepository
    {
        public Produto? GetById(Guid id)
        {
            using (var dataContext = new DataContext())
            {

            }
        }

        public Produto? GetByName(string nome)
        {
            using (var dataContext = new DataContext())
            {

            }
        }
    }
}
