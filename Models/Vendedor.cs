namespace ComercioBom.Models
{
     public sealed class Vendedor
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        
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