using System;

namespace P12_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 12");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

           //declaração variavel   // condição de 5 vezes  //incremento
            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)//----> conta 5 vezes relativo a ano 
            {
                for(int contadorMes = 1; contadorMes <= 12; contadorMes++) //----> conta 12 vezes relativo a mes 
                {
                    valorInvestido = valorInvestido * fatorRendimento;
                }
                fatorRendimento += 0.0010;
            }

    
            Console.WriteLine("Ao ternino do investimento,você terá R$ " + valorInvestido);

            Console.ReadLine();
        }
    }
}
