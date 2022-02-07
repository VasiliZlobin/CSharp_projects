using System;
/*
    Задача №41. Выяснить являются ли три числа сторонами треугольника.
*/

// метод заполнения массива значений из консоли
bool TryGetParameters(double[] parameters, (string, string) borders)
{
    bool result = false;
    Console.Write($"Введите {parameters.Length} числа, ограничивая их так: {borders.Item1}<число>{borders.Item2}: ");
    string input = Console.ReadLine();
    int curPos = 0;
    int count = 0;
    while (count < parameters.Length)
    {
        int posStart = input.IndexOf(borders.Item1, curPos);
        if (posStart == -1) break;
        int posEnd = input.IndexOf(borders.Item2, posStart + 1);
        if (posEnd == -1) break;
        if (double.TryParse(input.Substring(posStart + 1, posEnd - posStart - 1), out parameters[count]))
        {
            count++;
            curPos = posEnd;
        }
        else
        {
            break;
        }
    }
    result = count == parameters.Length;
    return result;
}

Console.WriteLine("Проверим существует ли треугольник с указанными сторонами.");
double[] sides = new double[3];
bool isError = true;
while (isError)
{
    isError = !TryGetParameters(sides, ("(", ")"));
}
bool isTriangle = sides[0] < sides[1] + sides[2]
                && sides[1] < sides[0] + sides[2]
                && sides[2] < sides[0] + sides[1];
string result = $"{(isTriangle ? "Существует" : "Не существует")} треугольник со сторонами: ";
foreach (double side in sides)
{
    result += side + " ";
}
Console.WriteLine(result);