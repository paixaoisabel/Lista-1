using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cotaçao;
            double dolar;
            double real;

            Console.Write("Digite o valor da cotação do Dolar: ");
            cotaçao = double.Parse(Console.ReadLine());

            Console.Write("Digite o Valor a ser convertido em Reais: ");
            dolar = double.Parse(Console.ReadLine());

            Console.Write("O valor em Reais é: R$ ");
            real = dolar * cotaçao;
            Console.WriteLine(real);
        }
    }
}
