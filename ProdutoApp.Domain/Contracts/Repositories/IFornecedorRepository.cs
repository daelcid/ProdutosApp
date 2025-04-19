using ProdutoApp.Domain.Models.Entities;

namespace ProdutoApp.Domain.Contracts.Repositories
{
    public interface IFornecedorRepository : IBaseRepository<Fornecedor>
    {
        Produto? GetById(Guid id);
        Produto? GetByName(string nome);
    }
}
