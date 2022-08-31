using Interfaz_Ejemplo.Accesorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaz_Ejemplo.Componentes;

namespace Interfaz_Ejemplo.Celulares
{
    internal class Celular
    {
        private  IAccesorio Accesorio;
        private IAccesorio Accesorio1;
        private Componente Bateria;
        private Componente Procesador;
        public Celular(IAccesorio Accesorio, IAccesorio accesorio1)
        {
            Accesorio = Accesorio;

            this.Bateria = new Bateria();
            this.Procesador = new Procesador();
            Accesorio1 = accesorio1;
        }
    }
}
