using System;

public class Carro
{
    // Instância privada e estática da classe Carro (garante que haja apenas uma instância global)
    private static Carro _instancia;

    // Propriedades do Carro
    public string Cor { get; set; }
    public string Modelo { get; set; }

    // Construtor privado para evitar a criação de instâncias fora da classe
    private Carro() 
    {
        // Definindo valores padrão para a instância
        Cor = "Preto";
        Modelo = "Sedan";
    }

    // Propriedade pública para acessar a instância do Carro
    public static Carro Instancia
    {
        get
        {
            // Cria a instância apenas quando for necessário (Lazy Initialization)
            if (_instancia == null)
            {
                _instancia = new Carro();
            }
            return _instancia;
        }
    }

    // Método para mostrar as informações do carro
eu crio     public void MostrarInformacoes()
    {
        Console.WriteLine($"Carro: {Modelo}, Cor: {Cor}");
    }
}

class Program
{
    static void Main()
    {
        // Acessando a instância do Carro usando o padrão Singleton
        Carro carro1 = Carro.Instancia;
        carro1.Cor = "Vermelho";
        carro1.Modelo = "Fusca";

        // Exibindo informações da instância
        carro1.MostrarInformacoes();

        // Acessando a mesma instância de novo
        Carro carro2 = Carro.Instancia;

        // Alterando a cor da mesma instância
        carro2.Cor = "Azul";

        // Exibindo as informações da instância novamente
        carro2.MostrarInformacoes();

        // Verificando se carro1 e carro2 são a mesma instância
        Console.WriteLine($"São a mesma instância? {ReferenceEquals(carro1, carro2)}");
    }
}
