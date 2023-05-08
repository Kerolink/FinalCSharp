using static System.Console;
using static System.Math;
string menuSelection = "";
string? readResult;

void MenorMayor()
{

    int[] numeros = { 5, 3, 8, 1, 7, 2 };
    int mayor = numeros[0];
    int menor = numeros[0];

    foreach (int numero in numeros)
    {
        if (numero > mayor)
        {
            mayor = numero;
        }
        if (numero < menor)
        {
            menor = numero;
        }
    }

    WriteLine("El mayor número es: " + mayor);
    WriteLine("El menor número es: " + menor);
    ReadLine();
}

void ParImpar()
{
    int numero = 0;
    Write("Ingrese un número entero: ");
    if (int.TryParse(ReadLine(), out numero))
        if (numero % 2 == 0)
        {
            WriteLine("El número es par");
        }
        else
        {
            WriteLine("El número es impar");
        }
    else
    {
        WriteLine("Ha entrado un número erroneo");
    }
    ReadLine();
}

void AnyoBisiesto()
{
    Write("Ingrese un año: ");
    int anio = 0;
    if (int.TryParse(ReadLine(), out anio))

        if ((anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0)
        {
            WriteLine(anio + " es un año bisiesto");
        }
        else
        {
            WriteLine(anio + " no es un año bisiesto");
        }
    else
        WriteLine("Ha entrado un año incorrecto");
}

void palindromo()
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

}

void ordenarLista()
{
    string[] nombres = { "Juan", "Maria", "Ana", "Pedro" };

    Array.Sort(nombres);

    WriteLine("Lista ordenada alfabéticamente:");

    foreach (string nombre in nombres)
    {
        WriteLine(nombre);
    }
}

void factorial()
{
    int num = 0, factorial = 1;

    Write("Introduce un número entero positivo: ");
    if (int.TryParse(ReadLine(), out num))
    {

        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }

        WriteLine("El factorial de {0} es {1}", num, factorial);
    }
    else
        WriteLine("Número inválido");

    ReadKey();
}

void NumeroPrimo()
{
    int num = 0, i;
    bool esPrimo = true;

    Write("Introduce un número entero positivo: ");
    if (!int.TryParse(ReadLine(), out num))
    {
        WriteLine("Número invalido");
        return;
    }

    for (i = 2; i < num; i++)
    {
        if (num % i == 0)
        {
            esPrimo = false;
            break;
        }
    }

    if (esPrimo)
        WriteLine("{0} es un número primo", num);
    else
        WriteLine("{0} no es un número primo", num);
}

void AreaVolumenCubo()
{
    double lado = 0, area, volumen;

    Write("Introduce el valor del lado del cubo: ");
    if (!double.TryParse(ReadLine(), out lado))
    {
        WriteLine("Lado invalido");
        return;
    }

    area = 6 * Pow(lado, 2);
    volumen = Pow(lado, 3);

    WriteLine("El área del cubo es {0}", area);
    WriteLine("El volumen del cubo es {0}", volumen);

    ReadKey();
}

void SumaNumerosPares()
{
    List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int suma = 0;

    foreach (int num in numeros)
    {
        if (num % 2 == 0)
            suma += num;
    }

    WriteLine("La suma de los números pares es {0}", suma);

    ReadKey();
}

void NumeroPositivoNegativoCero()
{

    int num;

    Write("Introduce un número entero: ");
    if (!int.TryParse(ReadLine(), out num))
    {
        WriteLine("Número invalido");
        return;
    }

    if (num > 0)
        WriteLine("{0} es un número positivo", num);
    else if (num < 0)
        WriteLine("{0} es un número negativo", num);
    else
        WriteLine("{0} es cero", num);

    ReadKey();
}

void MediaLista()
{
    int[] numeros = { 10, 20, 30, 40, 50 };
    double media = numeros.Average();
    WriteLine("La media es: " + media);
}

void AdivinarNumero()
{

    Random random = new Random();
    int numeroAleatorio = random.Next(1, 101);
    int intentos = 0;
    int numeroUsuario = 0;

    while (numeroUsuario != numeroAleatorio)
    {
        WriteLine("Adivina el número (entre 1 y 100):");
        if (!int.TryParse(ReadLine(), out numeroUsuario))
        {
            WriteLine("Número invalido");
            continue;
        }
        intentos++;

        if (numeroUsuario < numeroAleatorio)
        {
            WriteLine("El número introducido es menor que el número aleatorio.");
        }
        else if (numeroUsuario > numeroAleatorio)
        {
            WriteLine("El número introducido es mayor que el número aleatorio.");
        }
    }

    WriteLine("¡Has acertado el número en " + intentos + " intentos!");
}

void Anagrama()
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
}

void EliminarDuplicados()
{
    List<int> numeros = new List<int>() { 10, 20, 30, 20, 50 };

    List<int> numerosSinDuplicados = new List<int>();

    foreach (int numero in numeros)
    {
        if (!numerosSinDuplicados.Contains(numero))
        {
            numerosSinDuplicados.Add(numero);
        }
    }

    WriteLine("Números originales: " + string.Join(", ", numeros));
    WriteLine("Números sin duplicados: " + string.Join(", ", numerosSinDuplicados));

}

void Capicua()
{
    Console.Write("Ingresa un número: ");
    int num = 0;
    if (!int.TryParse(ReadLine(), out num))
    {
        WriteLine("Número invalido");
        return;
    }
    int originalNum = num;
    int reversedNum = 0;

    while (num > 0)
    {
        int digit = num % 10;
        reversedNum = (reversedNum * 10) + digit;
        num /= 10;
    }

    if (originalNum == reversedNum)
    {
        Console.WriteLine("El número es capicúa.");
    }
    else
    {
        Console.WriteLine("El número no es capicúa.");
    }
}


// display the top-level menu options
do
{
    Console.Clear();

    Console.WriteLine("Welcome to the my exercise: Your main menu options are:");
    Console.WriteLine(" 1. Menor Mayor");
    Console.WriteLine(" 2. Par Impar");
    Console.WriteLine(" 3. Año Bisiesto");
    Console.WriteLine(" 4. Palindromo");
    Console.WriteLine(" 5. Ordenar lista");
    Console.WriteLine(" 6. Factorial");
    Console.WriteLine(" 7. Numero primo");
    Console.WriteLine(" 8. Cubo");
    Console.WriteLine(" 9. Suma numeros Pares");
    Console.WriteLine(" 10. Numero Positivo Negativo Cero");
    Console.WriteLine(" 11. Media Lista");
    Console.WriteLine(" 12. Adivinar Numero");
    Console.WriteLine(" 13. Anagrama");
    Console.WriteLine(" 14. Eliminar Duplicados");
    Console.WriteLine(" 15. Capicua");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
        // NOTE: We could put a do statement around the menuSelection entry to ensure a valid entry, but we
        //  use a conditional statement below that only processes the valid entry values, so the do statement 
        //  is not required here. 
    }

    // use switch-case to process the selected menu option
    switch (menuSelection)
    {
        case "1":
            MenorMayor();
            break;

        case "2":
            ParImpar();
            break;

        case "3":
            AnyoBisiesto();
            break;

        case "4":
            palindromo();
            break;

        case "5":
            ordenarLista();
            break;

        case "6":
            factorial();
            break;

        case "7":
            NumeroPrimo();
            break;

        case "8":
            AreaVolumenCubo();
            break;

        case "9":
            SumaNumerosPares();
            break;

        case "10":
            NumeroPositivoNegativoCero();
            break;

        case "11":
            MediaLista();
            break;

        case "12":
            AdivinarNumero();
            break;

        case "13":
            Anagrama();

            break;

        case "14":
            EliminarDuplicados();
            break;

        case "15":
            Capicua();
            break;
        default:
            break;
    }
} while (menuSelection != "exit");