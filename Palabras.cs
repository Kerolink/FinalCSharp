using static System.Console;

class Palabras
{
    public void palindromo()
    {
        Write("Ingrese una palabra o frase: ");
        string? texto = ReadLine();
        if (texto == null)
        {
            Write("Texto invalido");
            return;
        }
        texto = texto.ToLower().Replace(" ", "");
        bool palindromo = true;
        for (int i = 0; i < texto.Length / 2; i++)
        {
            if (texto[i] != texto[texto.Length - 1 - i])
            {
                palindromo = false;
                break;
            }
        }

        if (palindromo)
        {
            WriteLine("La cadena es un palíndromo");
        }
        else
        {
            WriteLine("La cadena no es un palíndromo");
        }
        WriteLine();
        WriteLine("Presiona Enter para continuar");
        ReadLine();
    }

    public void Anagrama()
    {
        string? palabra1 = "";
        string? palabra2 = "";

        WriteLine("Ingrese una palabra");
        palabra1 = ReadLine();
        if (palabra1 == null)
        {
            WriteLine("Palabra inválida");
            return;
        }
        WriteLine("Ingrese otra palabra");
        palabra2 = ReadLine();
        if (palabra2 == null)
        {
            WriteLine("Palabra inválida");
            return;
        }

        char[] letras1 = palabra1.ToLower().ToCharArray();
        char[] letras2 = palabra2.ToLower().ToCharArray();

        Array.Sort(letras1);
        Array.Sort(letras2);

        bool sonAnagramas = letras1.SequenceEqual(letras2);

        if (sonAnagramas)
        {
            WriteLine(palabra1 + " y " + palabra2 + " son anagramas.");
        }
        else
        {
            WriteLine(palabra1 + " y " + palabra2 + " no son anagramas.");
        }
        WriteLine();
        WriteLine("Presiona Enter para continuar");
        ReadLine();
    }

    public void ordenarLista()
    {
        // Creamos la lista y las variables de control
        var input_list = new List<object>();
        var loop = true;
        var self_destruct = true;
        // Proceso
        try
        {
            // Mientras loop sea True preguntaremos al usuario si quiere anadir palabras
            while (loop == true)
            {
                WriteLine("Añade una palabra a la lista, no añada nada para dejar de añadir palabras: ");
                var user_input = ReadLine();
                // Si no se introduce nada loop cambia a False y se cierra el bucle
                if (user_input == "")
                {
                    loop = false;
                }
                else
                {
                    // Si se introduce una palabra se asigna al final de la lista de input_list
                    input_list.Add(user_input!.ToString());
                    // Tambien asignaremos self_destruct False
                    self_destruct = false;
                }
            }
            // Salida
            // Si al menos se introdujo un valor mostraremos la lista ordenada alfabéticamente
            if (self_destruct == false)
            {
                Console.WriteLine("A continuación aparecen las palabras que a introducido por orden alfabético: ");
                input_list.Sort();
                foreach (Object o in input_list)
                {
                    Console.WriteLine(o);
                }
            }
            else
            {
                // Si el usuario no llegó a introducir ni un solo valor, self_destruct seguirá siendo True y mostrará un mensaje
                Console.WriteLine("No has introducido nada :( ");
            }
        }
        catch
        {
            Console.WriteLine("Error");
        }

        WriteLine();
        WriteLine("Presiona Enter para continuar");
        ReadLine();
    }
}