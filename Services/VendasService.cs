using ComercioBom5.DTO;
using ComercioBom5.Context;
using ComercioBom5.Models;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ComercioBom5.Services
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
            _context.Vendas.Add(venda);
            _context.SaveChanges();
            var vendaRealizada = BuscarVendaPorId(venda.Id);
            vendaRealizada.Itens = _itensService.AdicionarItens(vendaRealizada.Id, realizarVendaDTO.itens);
            vendaRealizada.CalcularValorTotal();
            _context.SaveChanges();
            return vendaRealizada;
        }

        public List<Venda> ListarVendas()
        {
            return _context.Vendas.Include(venda => venda.Vendedor).Include(venda => venda.Itens).ToList();
        }

        public Venda BuscarVendaPorId(int id)
        {
            return _context.Vendas.FirstOrDefault(venda => venda.Id == id);
        }
    }
}