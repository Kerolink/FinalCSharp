using static System.Console;

class Numeros
{
    public void MenorMayor()
    {
        // Entrada
        // Creamos las variables; a Mayor le asignamos un valor valor bajo
        int Mayor = 0;
        // Y con Menor asignamos un valor enorme
        int Menor = 999999999;
        // Creamos la lista y las variables de control
        var input_list = new List<int>();
        var loop = true;
        var self_destruct = true;
        // Proceso
        try
        {
            // Mientras loop sea True preguntaremos al usuario si quiere anadir numeros
            while (loop == true)
            {
                WriteLine("Añade un número a la lista, no añada nada para dejar de añadir números: ");
                var user_input = ReadLine();
                // Si no se introduce nada loop cambia a False y se cierra el bucle
                if (user_input == "")
                {
                    loop = false;
                }
                else
                {
                    // Si se introduce un numero se asigna al final de la lista de input_list
                    input_list.Add(Convert.ToInt32(user_input));
                    // Tambien asignaremos self_destruct False
                    self_destruct = false;
                }
            }
            // Para cada valor de la lista, compararemos si es mayor o menor
            foreach (var x in input_list)
            {
                // Si x es mayor que Mayor asignamos a Mayor el valor de x
                if (x > Mayor)
                {
                    Mayor = x;
                }
                // Si x es menor que Menor asignamos a Menor el valor de x
                // Aqui habría problemas si iniciamos ambas variables a 0 porque ningun numero es menor a 0
                if (x < Menor)
                {
                    Menor = x;
                }
            }
            // Salida
            // Si al menos se introdujo un valor mostraremos Mayor y Menor
            if (self_destruct == false)
            {
                Console.WriteLine("El número mayor es {0}", Mayor);
                Console.WriteLine($"El número menor es {Menor}");
            }
            else
            {
                // Si el usuario no llegó a introducir ni un solo número, self_destruct seguirá siendo True y mostrará un mensaje
                Console.WriteLine("No introdujiste nada :( ");
            }
        }
        catch
        {
            // El programa dará error si el usuario introduce letras o espacios en lugar de numeros
            Console.WriteLine("Error");
        }

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

        var input_list = new List<int>();
        var loop = true;
        var self_destruct = true;
        // Proceso
        try
        {
            // Mientras loop sea True preguntaremos al usuario si quiere anadir numeros
            while (loop == true)
            {
                WriteLine("Añade un número a la lista, no añada nada para dejar de añadir números: ");
                var user_input = ReadLine();
                // Si no se introduce nada loop cambia a False y se cierra el bucle
                if (user_input == "")
                {
                    loop = false;
                }
                else
                {
                    // Si se introduce un numero se asigna al final de la lista de input_list
                    input_list.Add(Convert.ToInt32(user_input));
                    // Tambien asignaremos self_destruct False
                    self_destruct = false;
                }
            }
            // Salida
            // Si al menos se introdujo un valor mostraremos resultado
            if (self_destruct == false)
            {
                int suma = 0;

                foreach (int num in input_list)
                {
                    if (num % 2 == 0)
                        suma += num;
                }

                WriteLine("La suma de los números pares es {0}", suma);
            }
            else
            {
                // Si el usuario no llegó a introducir ni un solo número, self_destruct seguirá siendo True y mostrará un mensaje
                Console.WriteLine("No introdujiste nada :( ");
            }
        }
        catch
        {
            // El programa dará error si el usuario introduce letras o espacios en lugar de numeros
            Console.WriteLine("Error");
        }

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
        var input_list = new List<int>();
        var loop = true;
        var self_destruct = true;
        // Proceso
        try
        {
            // Mientras loop sea True preguntaremos al usuario si quiere anadir numeros
            while (loop == true)
            {
                WriteLine("Añade un número a la lista, no añada nada para dejar de añadir números: ");
                var user_input = ReadLine();
                // Si no se introduce nada loop cambia a False y se cierra el bucle
                if (user_input == "")
                {
                    loop = false;
                }
                else
                {
                    // Si se introduce un numero se asigna al final de la lista de input_list
                    input_list.Add(Convert.ToInt32(user_input));
                    // Tambien asignaremos self_destruct False
                    self_destruct = false;
                }
            }
            // Salida
            // Si al menos se introdujo un valor mostraremos resultado
            if (self_destruct == false)
            {
                double media = input_list.Average();
                WriteLine("La media es: " + media);
            }
            else
            {
                // Si el usuario no llegó a introducir ni un solo número, self_destruct seguirá siendo True y mostrará un mensaje
                Console.WriteLine("No introdujiste nada :( ");
            }
        }
        catch
        {
            // El programa dará error si el usuario introduce letras o espacios en lugar de numeros
            Console.WriteLine("Error");
        }

        WriteLine();
        WriteLine("Presiona Enter para continuar");
        ReadKey();
    }

    public void EliminarDuplicados()
    {
        var input_list = new List<int>();
        var loop = true;
        var self_destruct = true;
        // Proceso
        try
        {
            // Mientras loop sea True preguntaremos al usuario si quiere anadir numeros
            while (loop == true)
            {
                WriteLine("Añade un número a la lista, no añada nada para dejar de añadir números: ");
                var user_input = ReadLine();
                // Si no se introduce nada loop cambia a False y se cierra el bucle
                if (user_input == "")
                {
                    loop = false;
                }
                else
                {
                    // Si se introduce un numero se asigna al final de la lista de input_list
                    input_list.Add(Convert.ToInt32(user_input));
                    // Tambien asignaremos self_destruct False
                    self_destruct = false;
                }
            }
            // Salida
            // Si al menos se introdujo un valor mostraremos resultado
            if (self_destruct == false)
            {
                List<int> numerosSinDuplicados = new List<int>();

                foreach (int numero in input_list)
                {
                    if (!numerosSinDuplicados.Contains(numero))
                    {
                        numerosSinDuplicados.Add(numero);
                    }
                }

                WriteLine("Números originales: " + string.Join(", ", input_list));
                WriteLine("Números sin duplicados: " + string.Join(", ", numerosSinDuplicados));
            }
            else
            {
                // Si el usuario no llegó a introducir ni un solo número, self_destruct seguirá siendo True y mostrará un mensaje
                Console.WriteLine("No introdujiste nada :( ");
            }
        }
        catch
        {
            // El programa dará error si el usuario introduce letras o espacios en lugar de numeros
            Console.WriteLine("Error");
        }

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