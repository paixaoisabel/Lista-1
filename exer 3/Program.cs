using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d;
            int area;

            Console.Write("Digite o valor da diagonal: ");
            d = int.Parse(Console.ReadLine());

            Console.Write("O valor de sua área é: ");
            area = (d * d) / 2;
            Console.WriteLine(area);
        }
    }
}
