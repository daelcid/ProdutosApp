using AutoMapper;
using ProdutoApp.Domain.Models.DTOs.Request;
using ProdutoApp.Domain.Models.DTOs.Response;
using ProdutoApp.Domain.Models.Entities;

namespace ProdutoApp.Domain.Mappings
{
    public class ProfileMap : Profile
    {
        public ProfileMap()
        {
            CreateMap<ProdutoRequestDto, Produto>();
            CreateMap<Produto, ProdutoResponseDto>();

            CreateMap<FornecedorRequestDto, Fornecedor>();
            CreateMap<Fornecedor, FornecedorResponseDto>();
        }
    }
}
