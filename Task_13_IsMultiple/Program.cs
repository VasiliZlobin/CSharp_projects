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

Console.WriteLine("Проверим кратно ли первое введенное целое число второму");
int number1 = GetIntegerFromConsole("Введите первое целое число: ", (null, null));
int number2 = GetIntegerFromConsole("Введите второе целое число: ", (null, null));
if (number2 == 0)
{
    Console.WriteLine("На ноль делить нельзя!");
}
else {
    int remain = number1 % number2;
    if (remain == 0)
    {
        Console.WriteLine($"{number1} кратно {number2}.");
    }
    else
    {
        Console.WriteLine($"{number1} не кратно {number2}. Остаток: {remain}.");
    }
}