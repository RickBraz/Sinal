using System;

namespace Sinal
{
    class Program
    {
        static void Main(string[] args)
        {
            /*[console: Sinal] Leia um número inteiro e exiba "Negativo", "Zero" ou "Positivo", conforme o caso.

Ex.:

Digite um número: 35
Positivo
ou

Digite um número: -10
Negativo
ou

Digite um número: 0
Zero*/
            
            Console.WriteLine("digite um numero inteiro para saber se ele e positivo negativo ou se é zero");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x == 0)
            {
                Console.WriteLine("Zero");
            }
            else if (x <= 0)
            {
                Console.WriteLine("negativo");
            }
            else 
            {
                Console.WriteLine("positivo");
            }
           
        }
    }
}
