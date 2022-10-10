using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_abstratas_construtor.Classes
{
    internal class Carro : Veiculo
    {
        public Carro()
        {
        }

        public Carro(string modelo, string marca, TipoDeVeiculo tipo) : base(modelo, marca, tipo)
        {
        }

        public override string ToString()
        {
            return Modelo + " " + Marca + " " + Tipo;
        }

    }
}
