using System;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os valores para a equação do segundo grau, utilizando o método de 'Bhaskara'");

            Console.Write("(a) = ");
            double Va = Convert.ToDouble(Console.ReadLine());
            Console.Write("(b) = ");
            double Vb = Convert.ToDouble(Console.ReadLine());
            Console.Write("(c) = ");
            double Vc = Convert.ToDouble(Console.ReadLine());

            if (Va==0)
            {
                Console.WriteLine("Não é uma equação de segundo grau!");
            }
            else
            {
                double delta = Vb * Vb - 4 * Va * Vc;

                if (delta < 0)
                {
                    Console.WriteLine($"Como delta = {delta:N2}, a equação não possui raizes reais!");
                }
                else
                {
                    double X1 = (-Vb + Math.Sqrt(delta)) / (2 * Va);
                    double X2 = (-Vb - Math.Sqrt(delta)) / (2 * Va);
                    Console.WriteLine($"X1 = {X1:N2} X2 = {X2:N2}");
                }
            }

        }
    }
}
