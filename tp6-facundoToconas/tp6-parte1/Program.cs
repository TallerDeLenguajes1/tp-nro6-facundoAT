using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp6_parte1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, aux, numInv = 0;
            num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                aux = num % 10;
                if (num > 9)
                {
                    numInv = (aux + numInv) * 10;
                }
                else
                {
                    numInv = numInv + aux;
                }
                num = num / 10;
            }
            // numInv = numInv + aux;  PORQUE NO ME DEJA HACER ESTO?
            Console.WriteLine("numINv:" + numInv);
            Console.ReadKey();
        }
    }
}
