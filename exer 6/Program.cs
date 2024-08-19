using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double val1;
            double val2;
            double media;

            Console.Write("Digite o primeiro valor: ");
            val1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            val2 = double.Parse(Console.ReadLine());

            Console.Write("O valor da media geometrica é: ");
            media = Math.Sqrt(val1 * val2);
            Console.WriteLine(media);
        }
    }
}
