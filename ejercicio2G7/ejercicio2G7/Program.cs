using System;

namespace ejercicio2G7
{
    class Program
    {
        static void Main(string[] args)
        {
            Double number1 = 0;
            do
            {
                if (number1 < 1 || number1 > 15)
                {
                    Console.WriteLine("Ingrese un numero del 1 al 15");
                }
                number1 = Double.Parse(Console.ReadLine());
            } while (number1 > 15 || number1 < 1);
            for (int x = 0; x < number1; x++)
            {
                Console.Write("* ");
            }
            Console.ReadKey();
        }
    }
}