using static System.Console;

class Numeros
{
    public void MenorMayor()
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
        WriteLine();
        WriteLine("Presiona Enter para continuar");
        ReadLine();
    }

    public void ParImpar()
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
        WriteLine();
        WriteLine("Presiona Enter para continuar");
        ReadLine();
    }

    public void factorial()
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

        WriteLine();
        WriteLine("Presiona Enter para continuar");
        ReadKey();
    }

    public void NumeroPrimo()
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
        WriteLine();
        WriteLine("Presiona Enter para continuar");
        ReadKey();
    }

    public void SumaNumerosPares()
    {
        List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int suma = 0;

        foreach (int num in numeros)
        {
            if (num % 2 == 0)
                suma += num;
        }

        WriteLine("La suma de los números pares es {0}", suma);

        WriteLine();
        WriteLine("Presiona Enter para continuar");
        ReadKey();
    }


    public void NumeroPositivoNegativoCero()
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

        WriteLine();
        WriteLine("Presiona Enter para continuar");
        ReadKey();
    }

    public void MediaLista()
    {
        int[] numeros = { 10, 20, 30, 40, 50 };
        double media = numeros.Average();
        WriteLine("La media es: " + media);

        WriteLine();
        WriteLine("Presiona Enter para continuar");
        ReadKey();
    }

    public void EliminarDuplicados()
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

        WriteLine();
        WriteLine("Presiona Enter para continuar");
        ReadKey();

    }

    public void Capicua()
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
        WriteLine();
        WriteLine("Presiona Enter para continuar");
        ReadKey();
    }

}