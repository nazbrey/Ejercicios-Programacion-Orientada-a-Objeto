using modelo_MVC.Models;
using modelo_MVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo_MVC.Controllers
{
    internal class WorkController
    {
        private IView<Worker> view;

        public WorkController(IView<Worker> view)
        {
            this.view = view;
        }

        public void Crear(int id, int cedula, Enterprise enterprise)
        {
            Worker worker;

            worker = Worker.Build(id, cedula, enterprise);

            view.Render(worker);
        }



    }
}
