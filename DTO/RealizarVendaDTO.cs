using System.Collections.Generic;
using ComercioBom.Models;

namespace ComercioBom.DTO
{
    public class RealizarVendaDTO
    {
        public int VendedorId { get; set; }
        public List<ItemDTO> itens { get; set; }
    }
}