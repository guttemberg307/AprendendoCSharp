using System;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6");

            int idade = 32;
            int idadeGustavo = idade;

            idade = 20; //vai sobscrever o primeiro valor

            Console.WriteLine(idade);// idade será igual a 20
            Console.WriteLine(idadeGustavo);

            Console.ReadLine();
        }
    }
}
