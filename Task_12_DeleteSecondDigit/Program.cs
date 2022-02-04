/*
    Задача № 12. Удалить вторую цифру трёхзначного числа.
*/

// метод вычисления цифры в указанной позиции числа (позиция с конца, начинается с 1)
int GetDigitInPosition(int number, int position)
{
    int result = -1;
    if (position > 0)
    {
        int temp = number / (int)Math.Pow(10, position - 1);
        if (temp > 0)
        {
            result = temp % 10;
        }
    }
    return result;
}

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

int number = GetIntegerFromConsole("Введите натуральное трехзначное число: ", (100, 999));
int lastDigit = GetDigitInPosition(number, 1);
int firstDigit = GetDigitInPosition(number, 3);
Console.WriteLine($"{firstDigit}{lastDigit}");