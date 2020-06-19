using System;

namespace Sinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("digite um numero inteiro para saber se ele e positivo negativo ou se é zero: ");
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
