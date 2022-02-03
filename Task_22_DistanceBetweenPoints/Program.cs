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

// метод заполнения массива координат вводом из консоли
void FullArrayCoordinates(int[] coordinates, string partMessage)
{
    for (int i = 0; i < coordinates.Length; i++)
    {
        string message = $"Введите координату по оси №{i + 1}{partMessage}: ";
        coordinates[i] = GetIntegerFromConsole(message, (null, null));
    }
}

// метод расчета расстояния между двумя точками для n мерного пространства
double DistanceBetweenPoints(int measure)
{
    int[] coordinatesPoint1 = new int[measure];
    int[] coordinatesPoint2 = new int[measure];
    FullArrayCoordinates(coordinatesPoint1, " для первой точки");
    FullArrayCoordinates(coordinatesPoint2, " для второй точки");
    int sumSquad = 0;
    for (int i = 0; i < measure; i++)
    {
        sumSquad += (coordinatesPoint1[i] - coordinatesPoint2[i]) * (coordinatesPoint1[i] - coordinatesPoint2[i]);
    }
    return Math.Sqrt(sumSquad);
}

Console.WriteLine("Расстояние между точками в 2D");
Console.WriteLine($"Расстояние:{DistanceBetweenPoints(2)}");
Console.WriteLine("Расстояние между точками в 3D");
Console.WriteLine($"Расстояние:{DistanceBetweenPoints(3)}");