using System;

namespace Tabuada
{
    class Program
    {
        static int valor = 0;

        static void Main(string[] args)
        {
            Console.Write("Digite o número para saber a tabuada: ");
            valor = Int16.Parse(Console.ReadLine());

            for(int i=0; i<=10; i++){
                Console.WriteLine(valor +" * "+ i + " = " + (valor * i) );
            }

        }
    }
}
