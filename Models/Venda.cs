using System.Collections.Generic;

namespace ComercioBom5.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public int VendedorId { get; set; }
        public decimal ValorTotal { get; set; }
        public Vendedor Vendedor { get; set; }
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

        public decimal CalcularValorTotal()
        {
            decimal valorTotal = 0;
            foreach(var item in Itens)
            {
                valorTotal += item.Valor;
            }
            return valorTotal;
        }

    }
}