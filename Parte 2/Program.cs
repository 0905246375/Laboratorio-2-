// Declaracion de variables
int num1 = 0, num2 = 0;
int suma = 0, resta = 0, multiplicacion = 0, division = 0;

// Solicitud para que el usuario ingreses los numeros 
Console.WriteLine("Ingrese el primer número por favor (int):");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número por favor (int):");
num2 = Convert.ToInt32(Console.ReadLine());

// Calculo de la suma de dos números
suma = num1 + num2;

// Calculo de la resta de dos números
resta = num1 - num2;

// Calculo de la multiplicación de dos números
multiplicacion = num1 * num2;

// Calculo de la división de dos números
if (num2 != 0)

    division = num1 / num2;

else

    Console.WriteLine("No se puede dividir por cero.");



// Mostrar Resultado de:
// Suma
Console.WriteLine($"La suma de {num1} y {num2} es: {suma}");

// Resta
Console.WriteLine($"La resta de {num1} y {num2} es: {resta}");

// Multiplicación
Console.WriteLine($"La multiplicación de {num1} y {num2} es: {multiplicacion}");

// División
if (num2 != 0)

    Console.WriteLine($"La división de {num1} y {num2} es: {division}");

