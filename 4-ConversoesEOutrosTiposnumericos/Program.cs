using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposnumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario;
            salario = 1200.50;

            int salarioEmInteiro;
            salarioEmInteiro = (int)salario; // conversao de double para inteiro   isso é chamdo de TYPE CASTING 
            Console.WriteLine(salarioEmInteiro); // vai imprimir 1200 

            // o long é um tipo de variavel de 64 bits
            long idade = 130000000000000;
            Console.WriteLine(idade);

            // short é uma variavel de 16 bits
            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);
            
            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}
