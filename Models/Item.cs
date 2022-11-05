using System.Text.Json.Serialization;

namespace ComercioBom.Models
{    
    public sealed class Item
    {
        [JsonIgnore]
        public int Id { get; private set; }
        public int ProdutoId { get; private set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; private set; }
        public decimal Valor { get; set; }

        public Item()
        {
            
        }
     
        public Item(int id, int produtoId, int quantidade)
        {
            Id = id;
            ProdutoId = produtoId;
            Quantidade = quantidade;
        }
    }
}