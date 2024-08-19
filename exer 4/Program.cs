using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int area;

            Console.Write("Digite a altura: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite a base: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("A área é: ");
            area = (a * b) / 2;
            Console.WriteLine(area);
        }
    }
    }
}
