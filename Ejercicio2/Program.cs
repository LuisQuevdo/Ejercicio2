using System;

class Ejercicio2
{
    static void Main()
    {
        // Ejercicio 1: Conversión de string a int y suma
        Console.Write("Ingrese el primer número: ");
        string input1 = Console.ReadLine();
        Console.Write("Ingrese el segundo número: ");
        string input2 = Console.ReadLine();

        int num1 = int.Parse(input1);
        int num2 = int.Parse(input2);

        Console.WriteLine($"Suma: {num1 + num2}");

        // Ejercicio 2: Conversión de string a double y redondeo
        Console.Write("Ingrese un número decimal: ");
        string decimalInput = Console.ReadLine();
        double decimalValue = double.Parse(decimalInput);

        Console.WriteLine($"Número redondeado: {Math.Round(decimalValue)}");

        // Ejercicio 3: Conversión de double a int (truncado)
        Console.Write("Ingrese un número decimal: ");
        double truncValue = double.Parse(Console.ReadLine());
        int truncated = (int)truncValue;

        Console.WriteLine($"Original: {truncValue}, Truncado: {truncated}");

        // Ejercicio 4: Conversión de string a DateTime
        Console.Write("Ingrese una fecha (dd/mm/yyyy): ");
        string dateInput = Console.ReadLine();
        DateTime date = DateTime.ParseExact(dateInput, "dd/MM/yyyy", null);

        Console.WriteLine($"Fecha en formato largo: {date:dddd, dd MMMM yyyy}");
    }
}