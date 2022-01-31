Console.Write("Введите номер дня недели: ");
string input = Console.ReadLine();
int numDay = 0;
try
{
    numDay = int.Parse(input);
}
catch (FormatException e)
{}

string result = "";

if (numDay < 1 || numDay > 7)
{
    result = "Нет такого дня недели!";
}
else if (numDay == 1)
{
    result = "Понедельник";
}
else if (numDay == 2)
{
    result = "Вторник";
}
else if (numDay == 3)
{
    result = "Среда";
}
else if (numDay == 4)
{
    result = "Четверг";
}
else if (numDay == 5)
{
    result = "Пятница";
}
else if (numDay == 6)
{
    result = "Суббота";
}
else
{
    result = "Воскресенье";
}
Console.WriteLine(result);