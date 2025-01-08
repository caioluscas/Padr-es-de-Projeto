using System.Collections.Generic;

namespace Prototype
{
    public class Mercado
    {
        public string Nome { get; set; }
        public List<Produto> Produtos { get; set; }

        public Mercado(string nome)
        {
            Nome = nome;
            Produtos = new List<Produto>();
        }

        public Mercado Clone()
        {
            return (Mercado)this.MemberwiseClone();
        }

        public override string ToString()
        {
            string produtosInfo = string.Join(", ", Produtos);
            return $"{Nome}: {produtosInfo}";
        }
    }
}
