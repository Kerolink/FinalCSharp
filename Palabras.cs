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
        string palabra1 = "roma";
        string palabra2 = "amor";

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
        string[] nombres = { "Juan", "Maria", "Ana", "Pedro" };

        Array.Sort(nombres);

        WriteLine("Lista ordenada alfabéticamente:");

        foreach (string nombre in nombres)
        {
            WriteLine(nombre);
        }
        WriteLine();
        WriteLine("Presiona Enter para continuar");
        ReadLine();
    }
}