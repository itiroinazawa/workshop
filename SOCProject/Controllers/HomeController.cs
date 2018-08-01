using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SOCProject.Models;

namespace SOCProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            StandardModel modelo = new StandardModel();
            modelo.Descricao = "Descricao de todo o calculo gerado.";

            int primeiroParametro = 100;
            double segundoParametro = new Random().NextDouble();

            var resultado = (primeiroParametro) / (segundoParametro * (primeiroParametro - segundoParametro));

            modelo.ValorCalculado = resultado;

            modelo.Identificacao = 1;

            modelo.Descricao = modelo.Descricao + " os parametros do calculo são: " + primeiroParametro + " e " + segundoParametro;
            modelo.Descricao = modelo.Descricao + " o resultado do calculo foi: " + modelo.ValorCalculado;

            return View(modelo);
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

    public class StandardModel
    {
        public int Identificacao { get; set; }

        public String Descricao { get; set; }

        public Double ValorCalculado { get; set; }
    }

}
