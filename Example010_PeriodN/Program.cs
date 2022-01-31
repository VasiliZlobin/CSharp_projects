int num = 0;
while (num <= 0)
{
    Console.Write("Введите натуральное число: ");
    string input = Console.ReadLine();
    try
    {
        num = int.Parse(input);
    }
    catch (FormatException e)
    { }
}
int inCurString = 0;
int maxInString = 20;
for (int i = -1 * num; i <= num; i++)
{
    if (inCurString != 0) Console.Write(","); // вывести запятую перед вторым числом в строке

    if (inCurString == maxInString || i == num)
    {
        Console.WriteLine(i);
        inCurString = 0;
    }
    else
    {
        Console.Write(i);
        inCurString++;
    }
}