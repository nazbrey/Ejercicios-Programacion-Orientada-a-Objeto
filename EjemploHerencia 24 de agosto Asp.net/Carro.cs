using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia_24_de_agosto_Asp.net
{
    internal class Carro:Vehiculo
    {
        public string Referencia { get; private set; }
        public Carro(string Placa, String Marca,string TipoVehiculo,string Referencia):base(Placa, Marca,TipoVehiculo)    
        {
            this.Referencia = Referencia;
        }

    }
}
