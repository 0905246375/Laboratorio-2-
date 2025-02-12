//Declaracion de variables 
int num1;
double num2;
string texto;
bool verdaderoFalso;


//Solicitar al usuario ingresar valores 
Console.WriteLine("Por favor ingrese un valor entero (int):");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Por favor ingrese un valor de punto decimal  (double):");
num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Por favor ingrese valor de texto  (string):");
texto = Console.ReadLine();

Console.WriteLine("Por favor ingrese un valor boleano (true/false) (bool)");
verdaderoFalso = Convert.ToBoolean (Console.ReadLine());

//Mostrar los valores ingresados 
Console.WriteLine("Los valores ingresados son");
Console.WriteLine($"Variable int: {num1}");
Console.WriteLine($"Variable double: {num2}");
Console.WriteLine($"Variable string: {texto}");
Console.WriteLine($"Variable bool: {verdaderoFalso}");

// Esperar a que el usuario presione una tecla para salir
Console.WriteLine("Presiona cualquier tecla para salir...");
Console.ReadKey();
