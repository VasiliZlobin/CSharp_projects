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

int number = GetIntegerFromConsole("Введите натуральное двухзначное число: ", (10, 99));
int maxDigit = 0;
int nextPosition = 1;
int currentDigit = -1;
do
{
    currentDigit = GetDigitInPosition(number, nextPosition);
    if (currentDigit > maxDigit) maxDigit = currentDigit;
    nextPosition++;
    
} while (currentDigit != -1);
Console.WriteLine($"Максимальная цифра: {maxDigit}");