using System.Collections.Generic;

namespace ComercioBom.Models
{
    public sealed class Venda
    {
        public int Id { get; private set; }
        public int VendedorId { get; private set; }
        public Vendedor Vendedor { get; set; }
        public decimal ValorTotal { get; private set; }
        public ICollection<Item> Itens { get; set; } = new List<Item>();

        public Venda()
        {
            
        }
        public Venda(int id, int vendedorId)
        {
            Id = id;
            VendedorId = vendedorId;
        }

        public void AdicionarItensALista(List<Item> itens)
        {
            foreach(Item item in itens)
            {
                Itens.Add(item);
            }
        }

        public void CalcularValorTotal()
        {
            foreach(var item in Itens)
            {
                ValorTotal += item.Valor;
            }
        }

    }
}