namespace ComercioBom.Models
{
    public sealed class Produto
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public decimal Valor { get; private set; }
        
        public Produto()
        {
            
        }
        public Produto(int id, string nome, decimal valor)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
        }
    }
}