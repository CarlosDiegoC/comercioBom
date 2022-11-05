using AutoMapper;
using ComercioBom5.DTO;
using ComercioBom5.Models;

namespace ComercioBom5.Mapping
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