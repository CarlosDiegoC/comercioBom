namespace ComercioBom5.Models
{
     public class Vendedor
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