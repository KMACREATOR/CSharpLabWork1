using System;

class Program
{
    static void Main()
    {
        Console.WriteLine($"Минимальные и максимальные значения предопределённых типов данных CTS:");
        Console.WriteLine($"int: {int.MinValue} - {int.MaxValue}");
        Console.WriteLine($"long: {long.MinValue} - {long.MaxValue}");
        Console.WriteLine($"short: {short.MinValue} - {short.MaxValue}");
        Console.WriteLine($"byte: {byte.MinValue} - {byte.MaxValue}");
        Console.WriteLine($"float: {float.MinValue} - {float.MaxValue}");
        Console.WriteLine($"double: {double.MinValue} - {double.MaxValue}");
        Console.WriteLine($"decimal: {decimal.MinValue} - {decimal.MaxValue}");
        Console.WriteLine($"char: {char.MinValue} - {char.MaxValue}");
        Console.WriteLine($"bool: {false} - {true}"); // Для bool, только два значения
    }
}
