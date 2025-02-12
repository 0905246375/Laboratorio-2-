/*Enunciado 3: Verificación de acceso
Un usuario intenta iniciar sesión en una aplicación. Debes verificar:

Si el usuario ingresó el nombre y contraseña correctos, mostrar "Acceso concedido".
Si solo ingresó el nombre correcto pero la contraseña es incorrecta, mostrar "Contraseña incorrecta".
Si el nombre de usuario no existe, mostrar "Usuario no registrado".
¿Qué estructura usarías? ¿if-else o switch? ¿Por qué?
Usaria if-else porque permite manejar condiciones complejas y combinadas, como verificar tanto el nombre de usuario como la contraseña. 
*/
//Ejemplo enunciado  3 
// Diccionario de usuarios y contraseñas
var usuarios = new Dictionary<string, string>
   {
   { "usuario1", "contrasena1" },
   { "usuario2", "contrasena2" },
   { "usuario3", "contrasena3" }
   };

// Solicitar nombre de usuario y contraseña
Console.Write("Ingrese su nombre de usuario: ");
string nombreUsuario = Console.ReadLine();
Console.Write("Ingrese su contraseña: ");
string contrasena = Console.ReadLine();

// Verificar acceso
if (usuarios.ContainsKey(nombreUsuario))
{
    if (usuarios[nombreUsuario] == contrasena)
    {
        Console.WriteLine("Acceso concedido");
    }
    else
    {
        Console.WriteLine("Contraseña incorrecta");
    }
}
else
{
    Console.WriteLine("Usuario no registrado");
}
     
