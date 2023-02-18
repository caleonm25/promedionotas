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
            double nota1, nota2, nota3, promedio; 

            Console.Write("Ingrese la primera nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la tercera nota: ");
            nota3 = double.Parse(Console.ReadLine());

            promedio = Convert.ToDouble(nota1 + nota2 + nota3) / 3.0;
            promedio = Math.Round(promedio, 2);

            if (promedio >= 3.5)
            {
                Console.Write("Su nota es: " + promedio + " usted aprobo.");
            }
            else 
            {
                Console.Write("Su nota es: " + promedio + " usted reprobo.");

            }
            Console.ReadKey();
        }
    }
}
