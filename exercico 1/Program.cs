using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercico_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;
            int a;
            int area;

            Console.Write("Digite o valor da base do retângulo: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da altura do retângulo: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("A área do retângulo é: ");
            area = b * a;
            Console.WriteLine(area);
        }
    }
}
