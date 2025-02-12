/*Enunciado 1: Clasificación de edad
Un programa debe determinar la categoría de una persona según su edad:
Menos de 12 años: Niño
Entre 12 y 17 años: Adolescente
Entre 18 y 59 años: Adulto
60 años o más: Adulto mayor
¿Qué estructura usarías? ¿if-else o switch? ¿Por qué?
Usaria la if-else; porque  las condiciones dependen de rangos de valores numéricos y no de valores exactos
*/
//Ejemplo enunciado 1 
Console.Write("Ingrese su edad: ");
int edad = int.Parse(Console.ReadLine());

if (edad < 12)

    Console.WriteLine("Categoría: Niño");

else if (edad >= 12 && edad <= 17)

    Console.WriteLine("Categoría: Adolescente");

else if (edad >= 18 && edad <= 59)

    Console.WriteLine("Categoría: Adulto");

else if (edad >= 60)

    Console.WriteLine("Categoría: Adulto mayor");

