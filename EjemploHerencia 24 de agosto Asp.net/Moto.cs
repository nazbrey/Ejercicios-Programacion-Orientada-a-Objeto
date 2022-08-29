using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia_24_de_agosto_Asp.net
{
    internal class Moto: Vehiculo
    {
        public string Referencia { get; private set; }

        public Moto(string Placa, string Marca, string TipoVehiculo, string Referencia) : base(Placa, Marca,TipoVehiculo)
        {
            this.Referencia = Referencia;
        }
    }
}
