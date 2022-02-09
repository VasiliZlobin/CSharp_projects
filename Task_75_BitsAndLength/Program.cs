/* Задача №75. 
 Есть два массива info и data.
 Массив data состоит из нулей и единиц хранящий числа в двоичном представлении. Числа идут друг за другом без разделителей.
 Массив info состоит из чисел, которые представляют колличество бит чисел из массива data.
 Составить массив десятичных представлений чисел массива data с учётом информации из массива info.
*/
void PrintArray(int[] array)
{
    Console.Write("{");
    for (int i = 0; i < array.Length; i++)
    {
        if (i > 0) Console.Write(",");
        Console.Write(array[i]);
    }
    Console.WriteLine("}");
}

bool TryInputArray(int[] parameters, string separator)
{
    bool result = false;
    Console.Write($"Введите {parameters.Length} числа, разделяя их ({separator}): ");
    string input = Console.ReadLine()!;
    int curPos = 0;
    int count = 0;
    while (count < parameters.Length)
    {
        int posEnd = input.IndexOf(separator, curPos);
        string sub = String.Empty;
        if (posEnd == -1)
        {
            sub = input.Substring(curPos);
        }
        else
        {
            sub = input.Substring(curPos, posEnd - curPos);
        }
        if (int.TryParse(sub, out parameters[count]))
        {
            count++;
            curPos = posEnd + 1;
            if (curPos > input.Length) break;
        }
        else
        {
            break;
        }
    }
    result = count == parameters.Length;
    return result;
}

int[] GetBitsArray(int size)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(0, 2);
    }
    return result;
}

int[] info = new int[5];
bool isError = true;
while (isError)
{
    isError = !TryInputArray(info, ",");
}
// посчитать общее количество бит и сгенерировать случайны битовый массив этой длины
int countBits = 0;
foreach (int i in info)
{
    countBits += i;
}

int[] data = GetBitsArray(countBits);

int cursor = 0;
int[] result = new int[info.Length];
int nextPosition = 0;
isError = false;
for (int i = 0; i < info.Length; i++)
{
    if (cursor + info[i] <= data.Length)
    {
        int current = 0;
        // пройти по битовому массиву на указанную длину
        for (int j = cursor; j < cursor + info[i]; j++)
        {
            if (data[j] == 1)
            {
                current += (int)System.Math.Pow(2, info[i] - j + cursor - 1);
            }
        }
        result[nextPosition] = current;
        nextPosition++;
        cursor += info[i];
    }
    else
    {
        isError = true;
        break;
    }
}
Console.Write("Битовый массив: ");
PrintArray(data);
Console.Write("Массив длин: ");
PrintArray(info);

if (isError) Console.WriteLine("В битовом массиве недостаточно значений!");
Console.Write("Результат: ");
PrintArray(result);