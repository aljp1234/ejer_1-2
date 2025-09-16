using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double angulo;
            Console.WriteLine("Ingrese un angulo : ");
            angulo = Convert.ToDouble(Console.ReadLine());
            if (angulo == 0)
            {
                Console.WriteLine("El angulo es nulo");
            }
            else if (angulo > 0 && angulo < 90)
            {
                Console.WriteLine("El angulo es agudo");
            }
            else if (angulo == 90)
            {
                Console.WriteLine("El angulo es recto");
            }
            else if (angulo > 90 && angulo < 180)
            {
                Console.WriteLine("El angulo es obtuso");
            }
            else if (angulo == 180)
            {
                Console.WriteLine("El angulo es llano");
            }
            else if (angulo > 180 && angulo < 360)
            {
                Console.WriteLine("El angulo es concavo");
            }
            else if (angulo == 360)
            {
                Console.WriteLine("El angulo es completo");
            }
            else
            {
                Console.WriteLine("El valor invalido");
            }
            Console.WriteLine("El angulo es: " + angulo);
            Console.ReadKey();

        }
    }
}
