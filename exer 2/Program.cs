using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int area;

            Console.Write("Digite o valor da aresta: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Valor da área é: ");
            area = a * a;
            Console.WriteLine(area);
        }
    }
}
