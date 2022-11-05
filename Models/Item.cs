namespace ComercioBom5.Models
{    
    public class Item
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int VendaId { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }

        public Item()
        {
            
        }
     
        public Item(int id, int produtoId, int vendaId, int quantidade)
        {
            Id = id;
            ProdutoId = produtoId;
            VendaId = vendaId;
            Quantidade = quantidade;
            Valor = CalcularValorDoItem();
        }
        private decimal CalcularValorDoItem()
        {
            decimal valor = 0;
            Valor = Quantidade * Produto.Valor;
            return valor;
        }
    }
}