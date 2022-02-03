// метод ввода целого значения с проверкой
int GetIntegerFromConsole(string message, (int?, int?) range)
{
    int result = 0;
    bool isNotCorrect = true;
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

int number = GetIntegerFromConsole("Введите целое число: ", (null, null));
string part = number % 161 == 0 ? "" : " не";
Console.WriteLine($"{number}{part} кратно 7 и 23.");