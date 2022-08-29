using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia_24_de_agosto_Asp.net
{
    internal class Vehiculo
    {
        public string Marca { get; protected set; }
        public string Placa { get; protected set; }
       
        public string TipoVehiculo { get; protected set; }


        protected Vehiculo( string Placa,string TipoVehiculo, string Marca)
        {
            this.Marca = Marca;   
            this.Placa = Placa;
            this.TipoVehiculo = TipoVehiculo;
        }

     
    }
}
