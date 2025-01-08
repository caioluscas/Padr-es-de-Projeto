using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando o mercado original
            Mercado mercadoOriginal = new Mercado("Supermercado A");
            mercadoOriginal.Produtos.Add(new Produto("Arroz", 5.99));
            mercadoOriginal.Produtos.Add(new Produto("Feijão", 8.49));
            mercadoOriginal.Produtos.Add(new Produto("Óleo", 7.20));

            // Clonando o mercado
            Mercado mercadoClone = mercadoOriginal.Clone();
            mercadoClone.Nome = "Supermercado B";

            // Adicionando um produto no clone
            mercadoClone.Produtos.Add(new Produto("Açúcar", 4.30));

            // Exibindo os resultados
            Console.WriteLine("Mercado Original:");
            Console.WriteLine(mercadoOriginal);

            Console.WriteLine("\nMercado Clone:");
            Console.WriteLine(mercadoClone);
        }
    }
}
