void drawPoint(int x, int y)
{
    Console.SetCursorPosition(x, y);
    Console.WriteLine(".");
}

int xa = 50, ya = 1,
    xb = 1, yb = 40,
    xc = 100, yc = 40;

// вывести вершины треугольника
Console.Clear();
drawPoint(xa, ya);
drawPoint(xb, yb);
drawPoint(xc, yc);

int x = xa, y = ya;
// вывести точки половин отрезков
for (int i = 0; i < 10000; i++)
{
    // исключить выбор вершины а на первой итерации
    int pos = 0;
    if (i == 0)
    {
        pos = 1;
    }
    int what = new Random().Next(pos, 3);
    switch (what)
    {
        case 0:
            x = (x + xa) / 2;
            y = (y + ya) / 2;
            break;
        case 1:
            x = (x + xb) / 2;
            y = (y + yb) / 2;
            break;
        default:
            x = (x + xc) / 2;
            y = (y + yc) / 2;
            break;
    }
    drawPoint(x, y);
}
Console.ReadKey();
