using Proyecto5Tema2DiploWebCSharpMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto5Tema2DiploWebCSharpMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var productos = new List<Producto>
            {
            new Producto{ ID = 1,  Descripcion ="Boligrafo", Precio = 8.35},
            new Producto{ ID = 2,  Descripcion ="Cuaderno Grande", Precio = 21.5},
            new Producto{ ID = 3,  Descripcion ="Cuaderno Pequeño", Precio = 10},
            new Producto{ ID = 4,  Descripcion ="Folios 500 uds.", Precio = 550.55},
            new Producto{ ID = 5,  Descripcion ="Grapadora", Precio = 85.25},
            new Producto{ ID = 6,  Descripcion ="Tijeras", Precio = 62},
            new Producto{ ID = 7,  Descripcion ="Cinta adhesiva", Precio = 45.10},
            new Producto{ ID = 8,  Descripcion ="Rotulador", Precio = 20.75},
            new Producto{ ID = 9,  Descripcion ="Mochila escolar", Precio = 800.90},
            new Producto{ ID = 10,  Descripcion ="Pegamento barra", Precio = 30.15},
            new Producto{ ID = 11,  Descripcion ="Lapicero", Precio = 15.55},
            new Producto{ ID = 12,  Descripcion ="Grapas", Precio = 40.90}
            };
            /*var resulProductos = from Producto in productos
                                 where Producto.Descripcion.Contains("%I%")
                                 select Producto;
            return View(resulProductos);*/



            /*var resulProductos2 = from Producto in productos
                                 where Producto.Descripcion.StartsWith("%C")
                                 select Producto;
            return View(resulProductos2);*/


            /*var resulProductos3 = from Producto in productos
                                 where Producto.Descripcion.EndsWith("%O")
                                 select Producto;
            return View(resulProductos3);*/


            /*var resulProductos4 = from Producto in productos
                                  where Producto.Precio > 20
                                  select Producto;
            return View(resulProductos4);*/


            var resulProductos5 = from Producto in productos
                                  where Producto.Precio < 70
                                  select Producto;
            return View(resulProductos5);
        }

        
    }
}