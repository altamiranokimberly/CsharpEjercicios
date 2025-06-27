// See https://aka.ms/new-console-template for more information

/*
int numeroEntero = 100;
long numeroLargo = 1234567890123456789L;

float numeroDecimalSimple = 3.14F;

double numeroDecimalDoble = 3.14159265359;

decimal numeroDecimalAlto = 100.99M;

char letra = 'A';

string texto = "Hola, mundo";
bool esVerdad = true;


Console.WriteLine("int: " + numeroEntero);
Console.WriteLine("long: " + numeroLargo);
Console.WriteLine("float: " + numeroDecimalSimple);
Console.WriteLine("double: " + numeroDecimalDoble);
Console.WriteLine("decimal: " + numeroDecimalAlto);
Console.WriteLine("char: " + letra);
Console.WriteLine("string: " + texto);
Console.WriteLine("bool: " + esVerdad);

Console.ReadKey();
*/

// Conversión implícita - no necesita cast
int entero = 100;
long enteroLargo = entero; // int se convierte implícitamente a long

Console.WriteLine("Conversión implícita: int a long = " + enteroLargo);

// Conversión explícita - necesita cast
double numeroDecimal = 9.78;
int enteroConvertido = (int)numeroDecimal; // Se convierte explícitamente de double a int, se pierde la parte decimal

Console.WriteLine("Conversión explícita: double a int = " + enteroConvertido);
//puede perder información si el valor es grande
long numeroLargo = 2147483648; // valor superior al máximo de int
int numeroConvertido = (int)numeroLargo; // se hace cast explícito

Console.WriteLine("Conversión explícita: long a int = " + numeroConvertido);

// Conversión implícita desde float a double
float numeroFloat = 3.14F;
double numeroDouble = numeroFloat;

Console.WriteLine("Conversión implícita: float a double = " + numeroDouble);

// Conversión explícita desde double a float
double otroDouble = 3.14159265359;
float otroFloat = (float)otroDouble;

Console.WriteLine("Conversión explícita: double a float = " + otroFloat);

Console.ReadKey();

//coverToInt
//metodos para omprobar el tipo

int a = 10;
int b = 3;

Console.WriteLine("Suma: " + (a + b));        
Console.WriteLine("Resta: " + (a - b));      
Console.WriteLine("Multiplicación: " + (a * b)); 
Console.WriteLine("División: " + (a / b));   
Console.WriteLine("Módulo: " + (a % b));

bool condicion1 = true;
bool condicion2 = false;

Console.WriteLine("AND (&&): " + (condicion1 && condicion2));  // false
Console.WriteLine("OR (||): " + (condicion1 || condicion2));   // true
Console.WriteLine("NOT (!): " + (!condicion1));                // false
Console.WriteLine("XOR (^): " + (condicion1 ^ condicion2));    // true