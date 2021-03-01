using System;

namespace ejercicio3G7
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 0, number2 = 0;
            Console.Write("TODO SE PUEDE!\n \n");

            Console.WriteLine("\n Ingrese 2 numeros enteros , para ser calculador por el programa,se evaluarán los numeros pares que hay\n" +
                " entre estos 2, esto es verdadero siempre y cuando el primer numero sea menor que el segundo.\n \n");

            Console.WriteLine("Ingrese el primer numero");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            number2 = int.Parse(Console.ReadLine());

            if ((number1 % 2 == 0) == false)
            {
                if (number1 < number2)
                    number1++;
                if (number1 > number2)
                    number1--;
                Console.Write(number1 + ". ");
            }
            if (number2 > number1)
            {
                for (int x = number1; x < (number2 - 2); x += 2)
                {
                    number1 += 2;
                    Console.Write(number1 + ". ");
                }
            }
            else if (number1 > number2)
            {
                for (int x = number1; x > (number2 + 2); x -= 2)
                {
                    number1 -= 2;
                    Console.Write(number1 + ". ");
                }
            }
            Console.ReadKey();
        }
    }
}
