using System.ComponentModel.DataAnnotations;

namespace ProdutoApp.Domain.Models.DTOs.Request
{
    public class ProdutoRequestDto
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MaxLength(100, ErrorMessage = "O campo {0} deve conter no máximo {1} caracteres")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal? Preco { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int? Quantidade { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int? FornecedorId { get; set; }
    }
}
