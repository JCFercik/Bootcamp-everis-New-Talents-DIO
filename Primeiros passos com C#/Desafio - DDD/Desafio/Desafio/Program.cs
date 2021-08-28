/*
 Imprima o nome da cidade correspondente ao DDD existente na entrada. Imprima DDD nao cadastrado caso não 
 existir DDD correspondente ao número digitado.

Se a entrada for qualquer outro DDD que não esteja na tabela, o programa deverá informar:
DDD nao cadastrado
 */

using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um DDD\n" +
                "61 - 71 - 11 - 21 - 32 - 19 - 27 - 31");

            int ddd = Convert.ToInt32(Console.ReadLine());
            
            switch (ddd)
            {
                case 61:
                    Console.WriteLine("Brasilia");
                    break;
                case 71:                             
                    Console.WriteLine("Salvador");
                    break;
                case 11:
                    Console.WriteLine("Sao Paulo");
                    break;
                case 21:
                    Console.WriteLine("Rio de Janeiro");
                    break;
                case 32:
                    Console.WriteLine("Juiz de Fora");
                    break;
                case 19:
                    Console.WriteLine("Campinas");
                    break;
                case 27:
                    Console.WriteLine("Vitoria");
                    break;
                case 31:
                    Console.WriteLine("Belo Horizonte");
                    break;
                default:
                    Console.WriteLine("DDD nao cadastrado");
                    break;
            }
            
        }
    }    
}
