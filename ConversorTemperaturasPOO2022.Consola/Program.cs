using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConversorTemperaturasPOO2022.Entidades;

namespace ConversorTemperaturasPOO2022.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = 20;
            Console.WriteLine($"{celsius} grados equivalen a {Conversor.ConvertirDeCelsiusAFahrenheit(celsius)}");
            Console.ReadLine();
        }
    }
}
