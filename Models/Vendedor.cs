namespace ComercioBom.Models
{
     public sealed class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        
        public Vendedor()
        {
            
        }
        public Vendedor(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}