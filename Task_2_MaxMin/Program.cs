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
double[] numbers = {0, 0};
for (int i = 0; i < numbers.Length; i++)
{
    (bool, double) solution = (false, 0);
    while (!solution.Item1)
    {
        solution = inputNumber(i + 1);
        if (solution.Item1) numbers[i] = solution.Item2;
    }
}
string comparison = "=";
if (numbers[0] > numbers[1])
{
    comparison = ">";
}
else if (numbers[0] < numbers[1])
{
    comparison = "<";
}
Console.WriteLine($"{numbers[0]} {comparison} {numbers[1]}");