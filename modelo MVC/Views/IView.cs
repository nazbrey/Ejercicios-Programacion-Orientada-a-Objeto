using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelo_MVC.Controllers;
using modelo_MVC.Models;

namespace modelo_MVC.Views
{
    internal interface IView<Worker>
    {
        void Render(Worker worker);
    }
}