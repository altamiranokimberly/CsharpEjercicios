// See https://aka.ms/new-console-template for more information
using System;

namespace appTarea1
{
    class Tarea1
    {
        static void Main(string[] args)

        {
            
            double num1 = 34.6;
            double num2 = 65.4 * 8;
            //arreglos
            int[] x = new int[5];

            Console.WriteLine(num1+num2);
            Console.ReadKey();
            Console.WriteLine("Introduce tu nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Introduce tu edad: ");
            string edad = Console.ReadLine();

            Console.WriteLine("Introduce tu ciudad: ");
            string ciudad = Console.ReadLine();

            Console.WriteLine("Tu nombre es " + nombre + ", tienes " + edad + " años, y vives en " + ciudad + ".");

            Console.ReadKey();


        }
    }
}

