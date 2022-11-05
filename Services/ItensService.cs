using System.Collections.Generic;
using AutoMapper;
using ComercioBom.Context;
using ComercioBom.DTO;
using ComercioBom.Models;

namespace ComercioBom.Services
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

        public List<Item> AdicionarItens(List<ItemDTO> itens)
        {
            var listaItens = _mapper.Map<List<Item>>(itens);
            foreach(var item in listaItens)
            {
                item.Valor = CalcularValorDoItem(item);
                _context.Itens.Add(item);
            }
            _context.SaveChanges();
            return listaItens;
        }

        public decimal CalcularValorDoItem(Item item)
        {
            Produto produto = _context.Produtos.Find(item.ProdutoId);
            var valorDoItem = produto.Valor * item.Quantidade;
            return valorDoItem;
        }
    }
}