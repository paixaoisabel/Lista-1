using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val1;
            int val2;
            int val3;
            int val4;
            int media;

            Console.Write("Digite o primeiro valor: ");
            val1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            val2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            val3 = int.Parse(Console.ReadLine());

            Console.Write("digite o quarto valor: ");
            val4 = int.Parse(Console.ReadLine());

            Console.Write("O valor da média aritmética: ");
            media = (val1 + val2 + val3 + val4) / 4;
            Console.WriteLine(media);
        }
    }
}
