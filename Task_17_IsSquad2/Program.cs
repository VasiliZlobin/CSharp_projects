// метод ввода числа с проверкой
double GetDoubleFromConsole(string message)
{
    double result = 0;
    bool isNotCorrect = true;
    while (isNotCorrect)
    {
        Console.Write(message);
        string? input = Console.ReadLine();
        isNotCorrect = !double.TryParse(input, out result);
    }
    return result;
}

Console.WriteLine("Проверим является ли одно введенное целое число квадратом другого");
double number1 = GetDoubleFromConsole("Введите первое число: ");
double number2 = GetDoubleFromConsole("Введите второе число: ");
if (number1 == number2 * number2)
{
    Console.WriteLine($"{number1} является квадратом {number2}");
}
else if (number2 == number1 * number1)
{
    Console.WriteLine($"{number2} является квадратом {number1}");
}
else
{
    Console.WriteLine($"Ни одно из чисел {number1}, {number2} не является квадратом другого.");
}