namespace ProdutoApp.Domain.Models.Entities
{
    public class Produto
    {
        #region Propriedades
        
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public decimal? Preco { get; set; }
        public int? Quantidade { get; set; }
        public Guid FornecedorId { get; set; }

        #endregion

        #region Relacionamentos

        public Fornecedor? Fornecedor { get; set; } 

        #endregion
    }
}
