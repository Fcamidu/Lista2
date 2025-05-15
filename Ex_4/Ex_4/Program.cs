using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bas3;
            double h;

            Console.Write("Digite a altura do seu triangulo:");
            h  = double.Parse(Console.ReadLine());

            Console.Write("Digite a Base do seu triangulo:");
            bas3 = double.Parse(Console.ReadLine());

            if (bas3 >= 100)
            {
                Console.WriteLine("Terreno Muito Grande!!");
            }
            else
            {
                double area = (bas3 * h) / 2;
                Console.WriteLine("A area do triangulo é:{0}", area);
            }
        }
    }
}
