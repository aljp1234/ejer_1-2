using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double v;
            Console.WriteLine("Ingrese la distancia recorrida (en kilometros): ");
            double dsaut = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el tiempo que tardo en recorrer la distancia (en horas): ");
            double t = Convert.ToDouble(Console.ReadLine());
            v = Math.Round(dsaut / t);
            Console.WriteLine("La velocidad del auto es: " + v + " km/h");
            Console.ReadKey();

        }
    }
}
