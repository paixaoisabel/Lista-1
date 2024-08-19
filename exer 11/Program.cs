using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double resul;

            Console.Write("Digite o valor X: ");
            x = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor Y: ");
            y = double.Parse(Console.ReadLine());

            Console.Write("A potencia é de: ");
            resul = Math.Pow(x, y);
            Console.WriteLine(resul);

        }
    }
}
