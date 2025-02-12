/*Enunciado 2: Día de la semana
Se quiere crear un programa que reciba un número del 1 al 7 y devuelva el nombre del día correspondiente.

1 = Lunes
2 = Martes
3 = Miércoles
4 = Jueves
5 = Viernes
6 = Sábado
7 = Domingo
¿Qué estructura usarías? ¿if-else o switch? ¿Por qué?
Usaria switch,  porque es más adecuado para manejar un conjunto fijo de valores discretos, como los números del 1 al 7 en este caso.
*/
// Ejemplo enunciado 2 
// Solicitar un número del 1 al 7
Console.Write("Ingrese un número del 1 al 7: ");
int numero = int.Parse(Console.ReadLine());

// Determinar el día de la semana correspondiente utilizando switch
string dia;
switch (numero)
{
    case 1:
        dia = "Lunes";
        break;
    case 2:
        dia = "Martes";
        break;
    case 3:
        dia = "Miércoles";
        break;
    case 4:
        dia = "Jueves";
        break;
    case 5:
        dia = "Viernes";
        break;
    case 6:
        dia = "Sábado";
        break;
    case 7:
        dia = "Domingo";
        break;
    default:
        dia = "Número no válido. Debe ser un número del 1 al 7.";
        break;
}

// Mostrar el día correspondiente
Console.WriteLine($"El día correspondiente es: {dia}");





