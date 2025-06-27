/* Ejemplo de cómo se estructura un archivo en C#. Aunque esta versión es para .NET 5, a partir de la versión 6 
 * ya no es obligatorio incluir explícitamente el namespace, la clase y el método Main gracias a las funcionalidades 
 * de los nuevos modelos de Program.cs en .NET 6 y posteriores.
 */

//Ejemplos classlibraries/namespaces
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Buffers;

namespace HolaMundo
{
    class HolaMundo
    {
        static void Main(string[] args)
        {
            // Ejemplo básico de variables:
            int num1 = 22; // Variable entera
            String nombre = "Kim"; // Variable de tipo cadena
            char inicial = 'K'; // Variable de carácter
            bool visto = false; // Variable booleana (verdadero o falso)

            // Variable para almacenar áreas
            double area;
            int radio = 6; // Radio del círculo

            // Constantes: valores que no cambian durante la ejecución del programa.
            // Siempre deben tener un valor definido al momento de su declaración.
            const double pi = 3.1416; // Valor de pi
            const int diaNacimiento = 5; // Ejemplo de constante para un día específico

            // Cálculo del área del círculo
            area = pi * radio * radio;

            // Mostrar resultado en consola
            Console.WriteLine(area);
            Console.ReadKey(); // Esperar a que el usuario presione una tecla antes de cerrar la consola

            // En C#, hay que colocar sufijos en los literales para indicar el tipo, especialmente para float, decimal, etc.
            float f = 10F; 
            Console.WriteLine(f);
            Console.ReadKey();
        }
    }
}