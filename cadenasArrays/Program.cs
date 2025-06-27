// See https://aka.ms/new-console-template for more information
using System.Text;

StringBuilder sb = new StringBuilder();
sb.Append("Hola");
sb.Append(" ");
sb.Append("Mundo!");
Console.WriteLine(sb.ToString());

// Definir un array de enteros
int[] numeros = { 1, 2, 3, 4, 5 };

// Operación: recorrer y mostrar los números
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("Número en posición " + i + ": " + numeros[i]);
}

int[] edades = { 21, 34, 18, 27 };

// Encontrar el máximo valor en el array
int maxEdad = edades[0];
for (int i = 1; i < edades.Length; i++)
{
    if (edades[i] > maxEdad)
        maxEdad = edades[i];
}
Console.WriteLine("La edad máxima es: " + maxEdad);

int[,] matriz = {
    { 1, 2 },
    { 3, 4 }
};
Console.WriteLine("Elemento en fila 0, columna 1: " + matriz[0, 1]);
