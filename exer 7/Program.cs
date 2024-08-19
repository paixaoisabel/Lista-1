using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double m;
            double convercao;


            Console.Write("Digite a distancia em milha maritima: ");
            m = double.Parse(Console.ReadLine());

            Console.Write("A distancia em quilômetros é: ");
            convercao = (m * 1852) / 1000;
            Console.WriteLine(convercao);
        }
    }
}
