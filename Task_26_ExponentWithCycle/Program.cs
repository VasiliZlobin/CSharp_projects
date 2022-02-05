/*
    Задача №26. Возведите число А в натуральную степень B используя цикл.
*/

// метод ввода числа с проверкой
double GetNumberFromConsole(string message, (double?, double?) range, bool waitInteger)
{
    double result = 0;
    bool isNotCorrect = true;
    while (isNotCorrect)
    {
        Console.Write(message);
        string? input = Console.ReadLine();
        bool success = false;
        if (waitInteger)
        {
            // для проверки ввода целого числа воспользуемся промежуточной переменной
            int temp;
            success = int.TryParse(input, out temp);
            if (success) result = temp;
        }
        else
        {
            success = double.TryParse(input, out result);
        }
        if (success)
        {
            isNotCorrect = range.Item1 != null && result < range.Item1 || range.Item2 != null && result > range.Item2;
        }

    }
    return result;
}

double number = GetNumberFromConsole(waitInteger: false, range: (null, null), message: "Введите число: ");
int exponent = (int)GetNumberFromConsole("Введите натуральную степень: ", (1, null), true);
double result = number;
for (int i = 1; i < exponent; i++)
{
    result *= number;
}
Console.WriteLine($"{number}^{exponent} = {result}");