using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_abstratas_construtor.Classes
{
    internal class CarroDeCorrida : Veiculo
    {
        public CarroDeCorrida()
        {
        }

        public CarroDeCorrida(string modelo, string marca, TipoDeVeiculo tipo) : base(modelo, marca, tipo)
        {
        }
    }
}
