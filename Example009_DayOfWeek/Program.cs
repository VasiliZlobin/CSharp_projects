Console.Write("Введите номер дня недели: ");
string input = Console.ReadLine();
int numDay = 0;
try
{
    numDay = int.Parse(input);
}
catch (FormatException e)
{}

string[] names = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
string result = "";
if (numDay < 1 || numDay > 7)
{
    result = "Нет такого дня недели!";
}
else
{
    result = names[numDay - 1];
}
Console.WriteLine(result);