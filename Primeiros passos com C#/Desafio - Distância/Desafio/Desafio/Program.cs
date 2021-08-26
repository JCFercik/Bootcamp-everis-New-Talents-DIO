using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a distância entre Y e X em KM ");
            int quilometros = Int32.Parse(Console.ReadLine());
            int minutos = quilometros * 2; // Digite aqui o calculo dos minutos
            Console.WriteLine(minutos + " minutos");
        }
    }
}
