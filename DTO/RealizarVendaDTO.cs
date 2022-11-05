using System.Collections.Generic;
using ComercioBom5.Models;

namespace ComercioBom5.DTO
{
    public class RealizarVendaDTO
    {
        public int VendedorId { get; set; }
        public List<ItemDTO> itens { get; set; }
    }
}