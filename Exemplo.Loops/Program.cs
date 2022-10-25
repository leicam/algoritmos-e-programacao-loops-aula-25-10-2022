using System;

namespace Exemplo.Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            ExemploLoopFor();
            Console.ReadKey();
        }

        private void ExemploLoopInfinito()
        {
            //loop infinito
            while (true)
            {
                Console.WriteLine("PERDEU!");
            }
        }
        private static void ExemploLoopWhile()
        {
            Console.WriteLine("Informe um valor para contagem" +
                " regressiva?");
            int valor = int.Parse(Console.ReadLine());

            while (valor > 0)
            {
                valor = valor - 1;
                Console.WriteLine(valor);
            }
        }

        private static void ExemploLoopFor()
        {
            Console.WriteLine("Digite uma palavra para ser" +
                "soletrada");
            string palavra = Console.ReadLine();

            for(int contador = 0; 
                contador < palavra.Length; contador++)
            {
                Console.WriteLine(palavra[contador]);
            }
        }
    }
}