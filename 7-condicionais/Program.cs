using System;

namespace _7_condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeJoao = 14;
            int quantidadePesoas = 2;


            Console.WriteLine(idadeJoao);

            if (idadeJoao >= 18) // se joao tiver maior que 18 entra 
            {
                Console.WriteLine("João possui mais de 18 anos de idade. Pode entrar.");
            }
            else
            {
                if (quantidadePesoas >= 2)
                {
                    Console.WriteLine("´João não possui mais de 18 anos, mas está acompanhado. Pode entrar ");
                }

                else
                {
                    Console.WriteLine("Não foi permitida a entrada de João.");
                }

            }

            Console.ReadLine();
        }
    }
}
