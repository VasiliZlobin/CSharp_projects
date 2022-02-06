/*
    Задача №29. Написать программу вычисления произведения чисел от 1 до N (N!).
*/

using System.Numerics;

// метод ввода целого значения с проверкой
int GetIntegerFromConsole((int?, int?) range)
{
    int result = 0;
    bool isNotCorrect = true;
    string message = "Введите целое число";
    if (range.Item1 != null)
        message += $" от {range.Item1}";
    if (range.Item2 != null)
        message += $" по {range.Item2}";
    message += ": ";
    while (isNotCorrect)
    {
        Console.Write(message);
        string? input = Console.ReadLine();
        if (int.TryParse(input, out result))
        {
            isNotCorrect = range.Item1 != null && result < range.Item1 || range.Item2 != null && result > range.Item2;
        }

    }
    return result;
}

// метод вычисления факториала с проверкой переполнения
// возвращает строку
bool GetFactorial(int max, out string result)
{
    result = String.Empty;
    bool isOverflow = false;
    BigInteger factorial = max;
    for (int i = max - 1; i > 1; i--)
    {
        try
        {
            factorial *= i;
        }
        catch (OutOfMemoryException)
        {
            isOverflow = true;
        }
    }

    if (isOverflow)
    {
        return false;
    }
    else
    {
        result = factorial.ToString();
        return true;
    }
}

int max = GetIntegerFromConsole((1, null));
string factorial;
bool success = GetFactorial(max, out factorial);
if (success)
{
    Console.WriteLine($"{max}! = {factorial}");
}
else
{
    Console.WriteLine($"Переполнение при вычислении {max}!");
}