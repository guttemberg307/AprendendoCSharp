using System;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

            char primeiraLetra = 'a';// aspas simples para representar somente um caracter
            Console.WriteLine(primeiraLetra);


            // tem como parametro ascii table 65 representa a letra A 
            primeiraLetra = (char)65; // (char) entre parenteses é chamado de castig que convertera int em char 
            Console.WriteLine(primeiraLetra);

            // 66 representa a letra B
            primeiraLetra =(char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de tecnologia " + 2021;
            string cursosProgamacao =//tudo a frente do @ vira caracter 
 @" - .NET
 - Java
 - Javascript"; 

            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgamacao);




            Console.ReadLine();
        }
    }
}
