using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemaIterarioARecursivo
{
    internal class Program
    {
        static int CalcularFactorialRecursivo(int n)// Se declara el método que se va a utilizar de forma recursiva
        {
            if (n == 0)
            {
                return 1; // Condición de salida
            }
            else
            {
                return n * CalcularFactorialRecursivo(n - 1); // Segmento recursivo
            }
        }
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Por favor ingrese el valor para sacar el factorial");
            n = int.Parse(Console.ReadLine());
            int factorial = CalcularFactorialRecursivo(n);
            Console.WriteLine("El factorial de " + n + " es: " + factorial);
            Console.ReadKey();
        }
    }
}
