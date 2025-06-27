// See https://aka.ms/new-console-template for more information

int i = 1;
Console.WriteLine("WHILE:");

while (i <= 10)
{
    Console.Write(i + " ");
    i++;
}
Console.WriteLine();


int j = 1;
Console.WriteLine("DO...WHILE:");

do
{
    Console.Write(j + " ");
    j++;
} while (j <= 10);

Console.WriteLine();



Console.WriteLine("FOR:");

for (int k = 1; k <= 10; k++)
{
    Console.Write(k + " ");
}
Console.WriteLine();


string[] frutas = { "Manzana", "Banana", "Cereza" };
Console.WriteLine("FOREACH:");

foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
}

int edad = 18;

if (edad >= 18)
{
    Console.WriteLine("Eres mayor de edad");
}
else
{
    Console.WriteLine("Eres menor de edad");
}

char opcion = 'A';

switch (opcion)
{
    case 'A':
        Console.WriteLine("Opción A seleccionada");
        break;
    case 'B':
        Console.WriteLine("Opción B seleccionada");
        break;
    case 'C':
        Console.WriteLine("Opción C seleccionada");
        break;
    default:
        Console.WriteLine("Opción no válida");
        break;
}