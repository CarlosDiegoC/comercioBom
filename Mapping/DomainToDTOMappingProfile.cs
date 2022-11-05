using AutoMapper;
using ComercioBom.DTO;
using ComercioBom.Models;

namespace ComercioBom.Mapping
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<ItemDTO, Item>().ReverseMap();
            CreateMap<RealizarVendaDTO, Venda>().ReverseMap();
            CreateMap<ProdutoDTO, Produto>().ReverseMap();
        }
    }
}