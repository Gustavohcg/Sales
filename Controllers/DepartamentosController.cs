using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sales.Models;

namespace Sales.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamentos> lista = new List<Departamentos>();
            lista.Add(new Departamentos { nome = "TVS", id = 1 });
            lista.Add(new Departamentos { nome = "Computadores", id = 2 });

            return View();
        }
    }
}