using System;

namespace Prime_pRoyecto_de_Consola_En_Visual_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables and then initialize to zero.
            int num1 = 0; int num2 = 0;

            // Mostrar título como la aplicación de calculadora de la consola de C #.
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            // Pídale al usuario que escriba el primer número.
            Console.WriteLine("Escriba un número y luego presione Entrar");
            num1 = Convert.ToInt32(Console.ReadLine());

            // Pídale a la usuario que escriba el segundo número.
            Console.WriteLine("Escriba otro número y luego presione Entrar");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Pídale a la usuaria que elija una opción.
            Console.WriteLine("Elija una opción de la siguiente lista:");
            Console.WriteLine("\ta - Agregar");
            Console.WriteLine("\ts - Sustraer");
            Console.WriteLine("\tm - Multiplicar");
            Console.WriteLine("\td - Dividir");
            Console.Write("Tu opcion? ");

            // Use una declaración de cambio para hacer los cálculos.
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            // Espere a que el usuario responda antes de cerrar.
            Console.Write("Presione cualquier tecla para cerrar la aplicación de la consola Calculadora...");
            Console.ReadKey();
        }
    }
}
