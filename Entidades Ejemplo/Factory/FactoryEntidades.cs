using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_Ejemplo.Entidades;

namespace Entidades_Ejemplo.Factory
{
    public static class FactoryEntidades
    {
        public static Entidad CrearEmpresa()
        { return new Empresa();
               
        }
        public static Entidad CrearDueño()
        {
            return new Dueño();

        }
        public static Entidad CrearRepresentante()
        {
            return new Representante();

        }
        public static Entidad CrearTrabajador()
        {
            return new Trabajador();

        }
    }
}

