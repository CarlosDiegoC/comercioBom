using System.Collections.Generic;
using System.Linq;
using ComercioBom5.Context;
using ComercioBom5.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComercioBom5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VendedoresController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public VendedoresController(ApplicationDbContext context)
        {
            _context = context;
        }
             
        [HttpPost]
        public ActionResult<Vendedor> CriarVendedor(Vendedor vendedor)
        {
            _context.Vendedores.Add(vendedor);
            _context.SaveChanges();
            return Ok(vendedor);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Vendedor>> ListarVendedores()
        {
            var vendedores = _context.Vendedores.ToList();
            return Ok(vendedores);

        }
    }
}