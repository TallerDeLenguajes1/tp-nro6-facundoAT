using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    class Program
    {
        static void Main(string[] args)
        {
            int operacion, bandera = 1;
            double num1, num2, resultado;

            while (bandera == 1)
            {
                menu();
                operacion = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese dos numeros");
                num1 = double.Parse(Console.ReadLine());
                num2 = double.Parse(Console.ReadLine());
                resultado = calculadora(num1, num2, operacion);
                if (resultado != -999.0)
                {
                    Console.WriteLine("Resultado: {0}", resultado);
                }
                Console.WriteLine("Si desea hacer otra operacion ingrese 1");
                bandera = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("FIN");
            Console.ReadKey();
        }
        public static void menu()
        {
            Console.WriteLine("CALCULADORA");
            Console.WriteLine("Elija una operacion");
            Console.WriteLine("1) Suma \n2) Resta \n3) Multiplicacion \n4) Division");
        }
        public static double calculadora(double num1, double num2, int operacion)
        {
            double aux = -999.0;
            switch (operacion)
            {
                case 1:
                    aux = num1 + num2;
                    break;
                case 2:
                    aux = num1 - num2;
                    break;
                case 3:
                    aux = num1 * num2;
                    break;
                case 4:
                    aux = num1 / num2;
                    break;
                default:
                    Console.WriteLine("No existe esa opcion");
                    break;
            }
            return (aux);
        }
    }
}
