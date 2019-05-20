using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Responder las siguientes preguntas
            //¿String es una tipo por valor o un tipo por referencia ?
            //Por referencia
            //¿Qué secuencias de escape tiene el tipo string?
            //
            //¿Qué sucede cuando utiliza el carácter @ antes de una cadena de texto?
            //
            string texto, texto2;
            string subcadena = " ";
            Console.WriteLine("Ingrese una cadena");
            texto = Console.ReadLine();
            Console.WriteLine("Candena:" + texto);

            Console.WriteLine("Primer caracter de mi cadena");
            Console.WriteLine(texto.FirstOrDefault());

            Console.WriteLine("Longitud de mi cadena:" + texto.Length);

            Console.WriteLine("Ingrese una cadena para concatenarla con la ingresada anteriormente");
            texto2 = Console.ReadLine();
            texto2 = texto + texto2;
            Console.WriteLine("Concatenadas: " + texto2);

            Console.WriteLine("Subcadena desde el caracter 3 hasta el final");
            if (texto2.Length > 3)
            {
                subcadena = texto2.Substring(3);
            }
            Console.WriteLine(subcadena);

            Suma();
            Console.ReadKey();

        }
        static void Suma()
        {
            int num1, num2, resultado;
            String cadena;
            Console.WriteLine("Ingrese 2 numeros:");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            resultado = num1 + num2;
            cadena = resultado.ToString();
            Console.WriteLine("La suma entre " + num1.ToString() + " y " + num2.ToString() + " es: " + cadena);
        }
    }
}
