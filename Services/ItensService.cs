using System.Collections.Generic;
using AutoMapper;
using ComercioBom5.Context;
using ComercioBom5.DTO;
using ComercioBom5.Models;

namespace ComercioBom5.Services
{
    public class ItensService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public ItensService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Item> AdicionarItens(int vendaId, List<ItemDTO> itens)
        {
            var listaItens = _mapper.Map<List<Item>>(itens);
            foreach(var item in listaItens)
            {
                item.VendaId = vendaId;
            }
            _context.Itens.AddRange(listaItens);
            _context.SaveChanges();
            return listaItens;
        }
    }
}