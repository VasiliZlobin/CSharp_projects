Console.Write("Введите первое число: ");
string input = Console.ReadLine();
int num1 = int.Parse(input);
Console.Write("Введите второе число: ");
input = Console.ReadLine();
int num2 = int.Parse(input);
if (num1 == num2 * num2)
{
    Console.Write(num1);
    Console.Write(" является квадратом ");
    Console.WriteLine(num2);
}
else
{
    Console.Write(num1);
    Console.Write(" не является квадратом ");
    Console.WriteLine(num2);
}