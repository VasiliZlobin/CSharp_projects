int numberA = new Random().Next(1, 101);
int numberB = new Random().Next(1, 51);
string temp = numberA.ToString() + " + " + numberB.ToString() + " = ";
string resultSum = temp + (numberA + numberB);
string resultDiv = temp.Replace("+", "/") + ((double)numberA / numberB);
Console.WriteLine(resultSum);
Console.WriteLine(resultDiv);