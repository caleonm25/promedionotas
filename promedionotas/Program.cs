using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promedionotas
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, nota3;

            Console.Write("Ingrese la primera nota: ");
            nota1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la segunda nota: ");
            nota2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la tercera nota: ");
            nota3 = int.Parse(Console.ReadLine());

            double promedio = Convert.ToDouble(nota1 + nota2 + nota3) / 3;
            promedio = Math.Round(promedio, 2);

            if (promedio >= 35)
            {
                Console.Write("Su nota es: " + promedio + ", usted aprobo.");
            }
            else 
            {
                Console.Write("Su nota es: " + promedio + ", usted reprobo.");

            }
            Console.ReadKey();
        }
    }
}
