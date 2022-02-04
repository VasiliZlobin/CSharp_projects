/*
    Задача №24. Найти кубы чисел от 1 до N.
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
// определить вывод последнего результата и его длину
string lastResult = $" {max}^3 = {(double)max * max * max}";
int resultLength = lastResult.Length;
// посчитать сколько уместится в одной строке консоли
int countResultsInLine = Console.WindowWidth / resultLength;
if (countResultsInLine > 0)
{
    int currentPosition = 1;
    // вывести таблицу квадратов
    Console.Clear();
    for (int i = 1; i < max; i++)
    {
        string currentResult = $" {i}^3 = {(double)i * i * i}";
        int spaces = resultLength - currentResult.Length;
        for (int j = 0; j < spaces / 2; j++)
        {
            currentResult = " " + currentResult + " ";
        }
        if (spaces % 2 != 0)
            currentResult = currentResult + " ";

        if (currentPosition == countResultsInLine)
        {
            Console.WriteLine(currentResult);
            currentPosition = 1;
        }
        else
        {
            Console.Write(currentResult);
            currentPosition++;
        }
    }
    // вывести последний результат
    Console.WriteLine(lastResult);
}
else
{
    Console.WriteLine("Последний результат не уместится в строке!");
}