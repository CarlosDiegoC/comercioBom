using System.Collections.Generic;
using System.Linq;
using ComercioBom.DTO;
using ComercioBom.Context;
using ComercioBom.Models;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace ComercioBom.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
     public class ProdutosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public ProdutosController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public ActionResult<Produto> CriarProduto(ProdutoDTO produtoDTO)
        {
            var produto = _mapper.Map<Produto>(produtoDTO);
            _context.Produtos.Add(produto);
            _context.SaveChanges();
            return Ok(produto);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Produto>> ListarProdutos()
        {
            var produtos = _context.Produtos.ToList();
            return Ok(produtos);
        }
    }
}