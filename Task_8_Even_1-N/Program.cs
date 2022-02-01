int max = 0; 
while (max < 1)
{
    Console.Write("Введите натуральное число, больше 1: ");
    string input = Console.ReadLine();
    int.TryParse(input, out max);
}
Console.Write(2);
int num = 4;
while (num <= max)
{
    Console.Write($",{num}");
    num += 2;
}
Console.WriteLine("");