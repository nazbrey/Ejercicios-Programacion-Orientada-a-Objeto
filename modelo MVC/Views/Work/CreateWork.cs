using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelo_MVC.Controllers;
using modelo_MVC.Models;

namespace modelo_MVC.Views.CreateWork
{
    internal class CreateWork : IView<Worker>
    {
        public void Render(Worker obj)
        {
            Console.WriteLine("El id del trabajador es "+ obj.Id+"la cedula del estudiante es "+obj.Cedula+ "La empresa tiene nombre "+obj.Enterprise.Name);
        }
    }
}
