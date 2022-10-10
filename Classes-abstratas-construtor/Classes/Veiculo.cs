using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_abstratas_construtor.Classes
{
    internal abstract class Veiculo
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public TipoDeVeiculo Tipo { get; set; }

        protected Veiculo(string modelo, string marca, TipoDeVeiculo tipo)
        {
            Modelo = modelo;
            Marca = marca;
            Tipo = tipo;
        }
        public Veiculo()
        {

        }

        public enum TipoDeVeiculo
        {
            F1, Popular, SuperCarro
        }

        public override string ToString()
        {
            return Modelo + " " + Marca + " " + Tipo;
        }
    }
}
