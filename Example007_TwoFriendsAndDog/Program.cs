int count = 0;
double distance = 18000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
bool isFirstFriendNext = false;

while (distance > 10)
{
    // определить складываюмую скорость
    int currentSpeed = secondFriendSpeed;
    if (isFirstFriendNext)
    {
        currentSpeed = firstFriendSpeed;
    }
    // сменить направление
    isFirstFriendNext = !isFirstFriendNext;
    
    distance = distance - (distance / (currentSpeed + dogSpeed)) * (firstFriendSpeed + secondFriendSpeed);
    count++;
    Console.Write(count);
    Console.Write(") ");
    if (isFirstFriendNext)
    {
        Console.Write("|1 <- @2|");
    }
    else
    {
        Console.Write("|1@ -> 2|");
    }
    Console.Write(" осталось: ");
    Console.WriteLine(distance);
}

Console.Write("Собака пробежит ");
Console.Write(count);
Console.WriteLine(" раз");