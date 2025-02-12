//Declaracion de variables 
bool valor1 = false, valor2 = false;
bool resultadoAnd = false, resultadoOr = false;

//Solicitud para el usuario 
Console.WriteLine("Ingrese el primer valor booleano (true/false):");
valor1 = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine("Ingrese el segundo  valor booleano (true/false):");
valor2 = Convert.ToBoolean(Console.ReadLine());

// Calculo operaciones logicas 
resultadoAnd = valor1 && valor2; // And 
resultadoOr = valor1 || valor2;  // Or 

// Mostrar resultados
Console.WriteLine($"El resultado de {valor1} AND {valor2} es: {resultadoAnd}");
Console.WriteLine($"El resultado de {valor1} OR {valor2} es: {resultadoOr}");

Console.WriteLine("Presione cualquier tecla para salir");
Console.ReadKey();

