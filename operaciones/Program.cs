using System;
using System.Diagnostics.CodeAnalysis;

namespace operaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //suma
            int sum1, sum2, total;
            Console.WriteLine("Ingrese un número:");
            sum1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número:");
            sum2 = int.Parse(Console.ReadLine());
            total = sum1 + sum2;
            Console.WriteLine("El resultado es: " + total);
        }
    }
}
