using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cels;
            double temp;

            Console.Write("Digite o valor em Celsius: ");
            cels = Double.Parse(Console.ReadLine());

            Console.Write("O valor em Fahrenheit: ");
            temp = (cels * 1.8) + 32;
            Console.WriteLine(temp);
        }
    }
    }
}
