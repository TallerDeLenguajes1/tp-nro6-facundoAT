using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero, numero2;
            Console.WriteLine("Ingrese un numero");
            numero = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor Absoluto: {0}", Math.Abs(numero));
            Console.WriteLine("Elevado al cuadrado: {0}", Math.Pow(numero, 2));
            Console.WriteLine("Raiz cuadrada: {0}", Math.Pow(numero, 0.5));
            Console.WriteLine("Seno: " + Math.Sin(numero));
            Console.WriteLine("Coseno: " + Math.Cos(numero));
            Console.WriteLine("Parte entera:" + Math.Truncate(numero));

            Console.WriteLine("Ingrese dos numeros");
            numero = double.Parse(Console.ReadLine());
            numero2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Maximo entre los dos numeros:" + Math.Max(numero, numero2));
            Console.WriteLine("Minimo entre los dos numeros:" + Math.Min(numero, numero2));
            Console.ReadKey();
        }
    }
}
