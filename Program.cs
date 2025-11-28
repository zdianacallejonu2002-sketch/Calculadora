using System;

class Program
{
    static void Main()
    {
        double op1, op2;

        // Pedir operadores hasta que ambos sean positivos
        op1 = PedirOperador(1);
        op2 = PedirOperador(2);

        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\n--- MENÚ DE OPERACIONES ---");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Salir");
            Console.Write("Selecciona una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine($"Resultado de la suma: {op1 + op2}");
                    break;

                case "2":
                    Console.WriteLine($"Resultado de la resta: {op1 - op2}");
                    break;

                case "3":
                    Console.WriteLine($"Resultado de la multiplicación: {op1 * op2}");
                    break;

                case "4":
                    if (op2 == 0)
                    {
                        Console.WriteLine("No se puede dividir entre 0.");
                    }
                    else
                    {
                        Console.WriteLine($"Resultado de la división: {op1 / op2}");
                    }
                    break;

                case "5":
                    Console.WriteLine("Saliendo de la calculadora. Hasta luego");
                    salir = true;
                    break;

                default:
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                    break;
            }
        }
    }

    static double PedirOperador(int num)
    {
        while (true)
        {
            Console.Write($"Introduce el operador {num}: ");
            string entrada = Console.ReadLine();

            if (double.TryParse(entrada, out double valor) && valor >= 0)
            {
                return valor;
            }
            else
            {
                Console.WriteLine("El número debe ser positivo y válido. Inténtalo otra vez.");
            }
        }
    }
}
