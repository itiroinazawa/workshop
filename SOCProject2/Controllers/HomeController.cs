using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SOCProject2.Models;

namespace SOCProject2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private String CalcularValores(double parametro1, double parametro2)
        {
            Double resultado = 0.0;

            resultado = parametro1 + parametro2;

            for (int i = Convert.ToInt32(resultado) - 1; i > 1; i--)
            {
                resultado = resultado * i;
            }

            String final = "O resultado de todos os calculo é: " + resultado;

            return final;
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
