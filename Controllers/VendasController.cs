using System.Collections.Generic;
using AutoMapper;
using ComercioBom.DTO;
using ComercioBom.Models;
using ComercioBom.Services;
using Microsoft.AspNetCore.Mvc;

namespace ComercioBom.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VendasController : ControllerBase
    {
        private readonly VendasService _vendasService;
        private readonly IMapper _mapper;
        public VendasController(VendasService vendasService, IMapper mapper)
        {
            _vendasService = vendasService;
            _mapper = mapper;
        }
        
        [HttpPost]
        public ActionResult<Venda> RealizarVenda(RealizarVendaDTO realizarVendaDTO)
        {         
            var venda = _vendasService.RealizarVenda(realizarVendaDTO);
            return Ok(venda);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Venda>> ListarVendas()
        {
            var vendas = _vendasService.ListarVendas();
            return Ok(vendas);
        }

        [HttpGet("{id}")]
        public ActionResult<Venda> BuscarVenda(int id)
        {
            var venda = _vendasService.BuscarVendaPorId(id);
            return Ok(venda);
        }
    }
}