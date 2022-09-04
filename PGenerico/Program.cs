// See https://aka.ms/new-console-template for more information
using PGenerico.Entities;

using PGenerico.Collaborators;

Console.WriteLine("Hello, World!");
// trabajador 
Enterprise<Work> enterprise = new Enterprise<Work>();
enterprise.Asociar(new Work());

// Cordinador 

Enterprise<Coordinator> enterprisec = new Enterprise<Coordinator>();
enterprisec.Asociar(new Coordinator());
