using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer__12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double val1;
            double val2;
            double val3;
            double val4;
            double val5;
            double dinh;
            double resul;

            Console.Write("Valor do 1ºproduto: R$ ");
            val1 = double.Parse(Console.ReadLine());

            Console.Write("Valor do 2ºproduto: R$ ");
            val2 = double.Parse(Console.ReadLine());

            Console.Write("Valor do 3ºproduto: R$ ");
            val3 = double.Parse(Console.ReadLine());

            Console.Write("Valor do 4ºproduto: R$ ");
            val4 = double.Parse(Console.ReadLine());

            Console.Write("Valor do 5ºproduto: R$ ");
            val5 = double.Parse(Console.ReadLine());

            Console.Write("A soma dos produtos deu: R$ ");
            resul = (val1 + val2 + val3 + val4 + val5);
            Console.WriteLine(resul);

            Console.Write("Valor pago: R$ ");
            dinh = double.Parse(Console.ReadLine());

            Console.Write("O troco é: R$ ");
            resul = dinh - resul;
            Console.WriteLine(resul);
        }
    }
}
