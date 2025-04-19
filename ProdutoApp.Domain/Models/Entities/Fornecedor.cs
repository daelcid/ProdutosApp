namespace ProdutoApp.Domain.Models.Entities
{
    public class Fornecedor
    {
        #region Propriedades

        public Guid Id { get; set; }
        public string? Nome { get; set; }

        #endregion

        #region Relacionamentos

        public List<Produto> Produtos { get; set; }

        #endregion
    }
}
