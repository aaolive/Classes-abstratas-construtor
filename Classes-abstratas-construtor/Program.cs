using Classes_abstratas_construtor.Classes;

namespace Classes_abstratas_construtor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // classe Carro
            Veiculo carro = new Carro("Gol", "Wolkswagen", Veiculo.TipoDeVeiculo.Popular);
            Console.WriteLine(carro);

            // classe CarroDeCorrida
            Veiculo carro2 = new CarroDeCorrida("Ferrari F1 2022","Ferrari",Veiculo.TipoDeVeiculo.F1);
            Console.WriteLine(carro2);            

        }
    }
}