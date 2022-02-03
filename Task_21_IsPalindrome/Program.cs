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

int CountDigitsInNumber(int number)
{
    int nextPosition = 1;
    while (GetDigitInPosition(number, nextPosition) != -1)
    {
        nextPosition++;
    }
    return nextPosition - 1;
}

int number = GetIntegerFromConsole("Введите натуральное пятизначное число: ", (10000, 99999));
int count = CountDigitsInNumber(number);
string part = "";
if (count % 2 != 0)
{
    for (int i = 1; i <= count / 2; i++)
    {
        if (GetDigitInPosition(number, i) != GetDigitInPosition(number, count - i + 1))
        {
            part = "не ";
            break;
        }        
    }
}
else
{
    part = "не ";
}
Console.WriteLine($"{number} {part}является палиндромом.");