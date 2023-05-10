using static System.Console;

string menuSelection = "";
string? readResult;

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
            new Numeros().MenorMayor();
            break;

        case "2":
            new Numeros().ParImpar();
            break;

        case "3":
            new Fechas().AnyoBisiesto();
            break;

        case "4":
            new Palabras().Palindromo();
            break;

        case "5":
            new Palabras().OrdenarLista();
            break;

        case "6":
            new Numeros().Factorial();
            break;

        case "7":
            new Numeros().NumeroPrimo();
            break;

        case "8":
            new Formas().AreaVolumenCubo();
            break;

        case "9":
            new Numeros().SumaNumerosPares();
            break;

        case "10":
            new Numeros().NumeroPositivoNegativoCero();
            break;

        case "11":
            new Numeros().MediaLista();
            break;

        case "12":
            new Juegos().AdivinarNumero();
            break;

        case "13":
            new Palabras().Anagrama();
            break;

        case "14":
            new Numeros().EliminarDuplicados();
            break;

        case "15":
            new Numeros().Capicua();
            break;

        default:
            break;
    }
} while (menuSelection != "exit");