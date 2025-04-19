using ProdutoApp.Domain.Models.Entities;

namespace ProdutoApp.Domain.Contracts.Repositories
{
    public interface IProdutoRepository : IBaseRepository<Produto>
    {
        Produto? GetById(Guid id);
        Produto? GetByName(string nome);
    }
}
