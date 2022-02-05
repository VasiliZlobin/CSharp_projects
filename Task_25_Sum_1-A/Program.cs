/*
    Задача №25. Найти сумму чисел от 1 до А.
*/

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

int max = GetIntegerFromConsole((2, null));
long sum = ((long)max * max + max) / 2;
Console.WriteLine($"Сумма целых чисел от 1 до {max} равна {sum}.");