/*
    Задача №4. Найти максимальное из трех чисел.
    + дополнительная сложность: найти минимальное из этих трех чисел.
*/

(bool, double) inputNumber(int pos)
{
    (bool, double) result = (false, 0);
    Console.Write($"Введите число №{pos}: ");
    string input = Console.ReadLine();
    try
    {
        result.Item2 = double.Parse(input);
        result.Item1 = true;
    }
    catch (FormatException)
    { }
    return result;
}
// запрашивать ввод правильных чисел с проверкой
double[] numbers = { 0, 0, 0 };
for (int i = 0; i < numbers.Length; i++)
{
    (bool, double) solution = (false, 0);
    while (!solution.Item1)
    {
        solution = inputNumber(i + 1);
        if (solution.Item1)
            numbers[i] = solution.Item2;
    }
}
double max = numbers[0];
double min = numbers[0];
// вывести массив вместе с вычислением max и min
Console.Write($"[{max}");
for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    else if (numbers[i] < min)
    {
        min = numbers[i];
    }
    Console.Write($",{numbers[i]}");
}
Console.WriteLine("]");//закончили вывод массива
Console.WriteLine($"Максимальное число: {max}");
Console.WriteLine($"Минимальное число: {min}");