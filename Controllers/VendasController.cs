using System.Collections.Generic;
using AutoMapper;
using ComercioBom5.DTO;
using ComercioBom5.Models;
using ComercioBom5.Services;
using Microsoft.AspNetCore.Mvc;

namespace ComercioBom5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VendasController : ControllerBase
    {
        private readonly VendasService _vendasService;
        private readonly ItensService _itensService;
        private readonly IMapper _mapper;
        public VendasController(VendasService vendasService, ItensService itensService, IMapper mapper)
        {
            _vendasService = vendasService;
            _itensService = itensService;
            _mapper = mapper;
        }
        
        [HttpPost]
        public ActionResult<Venda> RealizarVenda(RealizarVendaDTO realizarVendaDTO)
        {
            
            var venda = _vendasService.RealizarVenda(realizarVendaDTO);
            _itensService.AdicionarItens(venda.Id, realizarVendaDTO.itens);

            return Ok(venda);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Venda>> ListarVendas()
        {
            var vendas = _vendasService.ListarVendas();
            return Ok(vendas);
        }
    }
}