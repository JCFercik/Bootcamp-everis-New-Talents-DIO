/*
    Desafio
    Você terá o desafio de ler um valor inteiro, que é o tempo de duração em segundos de um 
    determinado evento em uma loja, e informe-o expresso no formato horas:minutos:segundos.
 */

using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeInSeconds = int.Parse(Console.ReadLine());
            //timeInSeconds =  ;
            //continue a solucao
            var hours = (timeInSeconds/3600);
            var minutes = (timeInSeconds % 3600) / 60;
            var seconds = (timeInSeconds % 3600) % 60;

            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }
}
