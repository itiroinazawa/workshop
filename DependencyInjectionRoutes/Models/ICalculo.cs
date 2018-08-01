using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionRoutes.Models
{
    public interface ICalculo
    {
        Double CalcularSomaDoisParametros(double parametro1, double parametro2);

        Double CalcularMultiplicacaoDoisParametros(double parametro1, double parametro2);
    }
}
