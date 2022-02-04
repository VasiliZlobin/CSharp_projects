/*
    Задача № 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным.
*/

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

int number = GetIntegerFromConsole("Введите номер дня недели: ", (1, 7));
if (number > 5)
{
    Console.WriteLine("Это выходной день.");
}
else
{
    Console.WriteLine("Это рабочий день.");
}