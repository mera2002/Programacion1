using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//VICTOR RICARDO ALVAREZ SARAVIA 
//MERARY JULISSA ARAUJO VELASQUEZ 

namespace calculo_de_notas
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3;
            double NF;
            double P1, P2, P3;


            Console.WriteLine("Ingrese nota 1:");
            nota1 = double.Parse(Console.ReadLine());
           
            Console.WriteLine("Ingrese nota 2:");
            nota2 = double.Parse(Console.ReadLine());
           
            Console.WriteLine("Ingrese nota 3:");
            nota3 = double.Parse(Console.ReadLine());

            P1 = 35 * nota1 / 100;
            P2 = 30 * nota1 / 100;
            P3 = 25 * nota1 / 100;

            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Primera nota la cual su valor aplicado del 35% es: " + P1);
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Segunda nota la cual su valor aplicado del 30% es: " + P2);
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Tercera nota la cual su valor aplicado del 25% es: " + P3);
            Console.WriteLine("------------------------------------------------------------------------");

            NF = P1 + P2 + P3;

            Console.WriteLine("La nota final es: " + NF);
            Console.ReadKey();
        }
    }
}
