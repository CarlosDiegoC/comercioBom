using ComercioBom.DTO;
using ComercioBom.Context;
using ComercioBom.Models;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ComercioBom.Services
{
    public class VendasService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ItensService _itensService;
        public VendasService(ApplicationDbContext context, IMapper mapper, ItensService itensService)
        {
            _context = context;
            _mapper = mapper;
            _itensService = itensService;
        }
        public Venda RealizarVenda(RealizarVendaDTO realizarVendaDTO)
        {
            var venda = _mapper.Map<Venda>(realizarVendaDTO);
            venda.Itens = _itensService.AdicionarItens(realizarVendaDTO.itens);
            venda.CalcularValorTotal();
            _context.Vendas.Add(venda);
            _context.SaveChanges();
            return venda;
        }

        public List<Venda> ListarVendas()
        {
            return _context.Vendas.Include(venda => venda.Vendedor).Include(venda => venda.Itens).ToList();
        }

        public Venda BuscarVendaPorId(int id)
        {
            return _context.Vendas.Include(venda => venda.Vendedor).Include(venda => venda.Itens).FirstOrDefault(venda => venda.Id == id);
        }
    }
}