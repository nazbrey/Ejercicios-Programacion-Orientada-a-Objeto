// See https://aka.ms/new-console-template for more information
using modelo_MVC.Controllers;
using modelo_MVC.Views;
using modelo_MVC.Models;
using modelo_MVC.Views.CreateWork;

Console.WriteLine("Hello, World!");
WorkController work = new WorkController(new CreateWork());
work.Crear(1, 123, Enterprise.Build(1, "Adn", "65 CALLE"));