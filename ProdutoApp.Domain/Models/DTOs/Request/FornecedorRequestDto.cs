using System.ComponentModel.DataAnnotations;

namespace ProdutoApp.Domain.Models.DTOs.Request
{
    public class FornecedorRequestDto
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MaxLength(100, ErrorMessage = "O campo {0} deve conter no máximo {1} caracteres")]
        public string? Nome { get; set; }
    }
}
