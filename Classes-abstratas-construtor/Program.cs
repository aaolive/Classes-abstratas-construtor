using Classes_abstratas_construtor.Classes;

namespace Classes_abstratas_construtor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Veiculo carro = new Carro("Gol", "Wolkswagen", Veiculo.TipoDeVeiculo.Popular);
            Console.WriteLine(carro);

            Veiculo carro2 = new CarroDeCorrida();            

        }
    }
}