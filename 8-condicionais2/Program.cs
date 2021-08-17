using System;

namespace _7_condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condicionais 2 ");
            

            int idadeJoao = 14;
            // int quantidadePesoas = 2;

            // bool acompanhado = quantidadePesoas >= 2;

            bool acompanhado = false;// false 
                    
                             //||       
            if (idadeJoao > 18 && acompanhado == true)// se joao tiver maior que 18 entra  e tiver acompanhado pode entrar 
            {
                Console.WriteLine(" Pode entrar.");
            }
            else
            {             
                Console.WriteLine(" Não pode entrar");
            }

            Console.ReadLine();
        }
    }
}
