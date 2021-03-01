using System;

namespace ejercicio1Guia7
{
    class Program
    {
        static void Main(string[] args)
        {
            String kg = "";
            Double number1 = 0, number2 = 0, number3 = 0;
            int go = 0;
            do
            {
                Console.Title = "Menú de variables";
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("                              Selecciona tu variable");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("[a] Seno de X     [b] Coseno de X     [c] Tangente de X     [d] Raíz cuadrade de X\n" +
                    "[e] Potencia de Y^X     [f] Verificar si X es par o impar     [g] Salir del programa");
                kg = Console.ReadLine();
                if (kg != "g")
                {
                    Console.WriteLine("Ingrese el dato que vamos a calcular ");
                    do
                    {
                        try
                        {
                            number1 = Double.Parse(Console.ReadLine());
                            go = 1;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ingrese un dato numérico");
                        }
                    } while (go == 0);
                }
                switch (kg)
                {
                    case "a":
                        number2 = Math.Sin(number1);
                        Console.WriteLine("El Seno de \"" + number1 + "\" es igual a: " + number2);
                        go = 0;
                        break;
                    case "b":
                        number2 = Math.Cos(number1);
                        Console.WriteLine("El Coseno de \"" + number1 + "\" es igual a: " + number2);
                        go = 0;
                        break;
                    case "c":
                        number2 = Math.Tan(number1);
                        Console.WriteLine("La Tangente de \"" + number1 + "\" es igual a: " + number2);
                        go = 0;
                        break;
                    case "d":
                        number2 = Math.Sqrt(number1);
                        Console.WriteLine("La raíz cuadrada de \"" + number1 + "\" es igual a: " + number2);
                        go = 0;
                        break;
                    case "e":
                        Console.WriteLine("Ingrese el dato \"Y\" a elavar a la " + number1 + " potencia");
                        number3 = Double.Parse(Console.ReadLine());
                        number2 = Math.Pow(number3, number1);
                        Console.WriteLine("La potencia \"" + number1 + "\" del numero \"" + number3 + "\" es igual a: " + number2);
                        go = 0;
                        break;
                    case "f":
                        if (number1 % 2 == 0)
                        {
                            Console.WriteLine("El numero \" " + number1 + " \"  es par.");
                        }
                        else
                        {
                            Console.WriteLine("El numero\"" + number1 + "\" es impar.");
                        }
                        go = 0;
                        break;
                    case "g":
                        Console.WriteLine("Gracias por usar este programa \n");
                        go = 1;
                        break;
                    default:
                        go = 0;
                        break;
                }
                Console.WriteLine("\n Presiona cualquier tecla para salir del ejecutable");
                Console.ReadKey();
            } while (go == 0);
        }
    }
}