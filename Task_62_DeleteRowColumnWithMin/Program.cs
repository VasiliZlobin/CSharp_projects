/*
    Задача №62. В двумерном массиве целых чисел. Удалить строку и столбец, 
    на пересечении которых расположен наименьший элемент.
*/

void FillArray2D(int[,] array2D)
{
    Random rnd = new Random();
    int countRows = array2D.GetLength(0);
    int countColumns = array2D.GetLength(1);
    for (int rowIndex = 0; rowIndex < countRows; rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < countColumns; columnIndex++)
        {
            array2D[rowIndex, columnIndex] = rnd.Next(-100, 100);
        }
    }
}

void PrintArray2D(int[,] array2D, (int?, int?) size)
{
    Console.Write("{");
    int countRows = size.Item1 == null ? array2D.GetLength(0) : (int)size.Item1;
    int countColumns = size.Item2 == null ? array2D.GetLength(1) : (int)size.Item2;
    for (int rowIndex = 0; rowIndex < countRows; rowIndex++)
    {
        if (rowIndex != 0) Console.Write(", ");
        Console.Write("(");
        for (int columnIndex = 0; columnIndex < countColumns; columnIndex++)
        {
            if (columnIndex != 0) Console.Write(", ");
            Console.Write(array2D[rowIndex, columnIndex]);
        }
        Console.Write(")");
    }
    Console.WriteLine("}");
}

(int, int) FindPositionMinInArray2D(int[,] array2D)
{
    (int, int) result = (0, 0);
    int min = array2D[0, 0];
    int countRows = array2D.GetLength(0);
    int countColumns = array2D.GetLength(1);
    for (int rowIndex = 0; rowIndex < countRows; rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < countColumns; columnIndex++)
        {
            if (array2D[rowIndex, columnIndex] < min)
            {
                min = array2D[rowIndex, columnIndex];
                result = (rowIndex, columnIndex);
            }
        }
    }
    Console.WriteLine($"Минимальное число [{result.Item1}, {result.Item2}]: " + min);
    return result;
}

void DeleteColumnAndRowWithMin(int[,] array2D, (int, int) positionMin)
{
    // в строках сместить все колонки после позиции минимального значения влево
    // сместить позицию строки для значений в строках после строки минимального значения влево
    for (int rowIndex = 0; rowIndex < array2D.GetLength(0) - 1; rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < array2D.GetLength(1) - 1; columnIndex++)
        {
            int newRow = -1;
            int newColumn = -1;
            if (columnIndex >= positionMin.Item2) newColumn = columnIndex + 1;
            if (rowIndex >= positionMin.Item1) newRow = rowIndex + 1;
            if (newRow != -1 || newColumn != -1)
            {
                newRow = newRow == -1 ? rowIndex : newRow;
                newColumn = newColumn == -1 ? columnIndex : newColumn;
                int temp = array2D[rowIndex, columnIndex];
                array2D[rowIndex, columnIndex] = array2D[newRow, newColumn];
                array2D[newRow, newColumn] = temp;
            }
        }
    }
}

int[,] array2D = new int[9, 4];
FillArray2D(array2D);
Console.WriteLine($"Случайный двумерный массив {array2D.GetLength(0)} Х {array2D.GetLength(1)}");
PrintArray2D(array2D, (null, null));
(int, int) positionMin = FindPositionMinInArray2D(array2D);
DeleteColumnAndRowWithMin(array2D, positionMin);
Console.WriteLine($"После удаления строки и столбца с минимальным значением");
PrintArray2D(array2D, (array2D.GetLength(0) - 1, array2D.GetLength(1) - 1));
