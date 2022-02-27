using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1;
            double numero2;

            Console.WriteLine("Por favor insira o primeiro número a ser calculado: ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("######################################################\n");
            Console.WriteLine("Por favor insira o segundo número a ser calculado: ");
            numero2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("######################################################\n");

            Console.WriteLine($"Soma: {numero1} + {numero2} = " + String.Format("{0:0.00}", numero1 + numero2));
            Console.WriteLine($"Subtração: {numero1} - {numero2} = " + String.Format("{0:0.00}", numero1 - numero2));
            Console.WriteLine($"Multiplicação: {numero1} * {numero2} = " + String.Format("{0:0.00}", numero1 * numero2));
            Console.WriteLine($"Divisão: {numero1} / {numero2} = " + String.Format("{0:0.00}", numero1 / numero2));

        }
    }
}
