using System;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 9 - Escopo ");


            int idadeJoao = 18;
            bool acompanhado = true;
            string menssagemAdicional;

            if (acompanhado == true)
            {
                menssagemAdicional = "(João está acompanhado!)";
            }
            else
            {
                menssagemAdicional = "(joâo não está acompanhado)";
            }

            if (idadeJoao >= 18 || acompanhado == true)// se joao tiver maior que 18 entra  e tiver acompanhado pode entrar 
            {
                Console.WriteLine(" Pode entrar.");
                Console.WriteLine(menssagemAdicional);
            }
            else
            {
                Console.WriteLine(" Não pode entrar");
            }

            Console.ReadLine();
        }
    }
}
