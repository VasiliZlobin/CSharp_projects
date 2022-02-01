int num = 0;
bool isNotInt = true;
while (isNotInt)
{
    Console.Write("Введите целое число: ");
    string input = Console.ReadLine();
    isNotInt = !int.TryParse(input, out num);
}
Console.WriteLine($"{num} - число " + (num % 2 == 0 ? "четное" : "нечетное"));