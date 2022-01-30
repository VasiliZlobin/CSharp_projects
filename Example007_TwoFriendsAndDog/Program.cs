int count = 0;
double distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
bool isFirstFriendNext = false;

while (distance > 10)
{
    int currentSpeed = secondFriendSpeed;
    if (isFirstFriendNext)
    {
        currentSpeed = firstFriendSpeed;
    }
    double time = distance / (currentSpeed + dogSpeed);
    distance = distance - time * (firstFriendSpeed + secondFriendSpeed);
    count++;
    Console.Write(count);
    Console.Write(") осталось: ");
    Console.WriteLine(distance);
}

Console.Write("Собака пробежит ");
Console.Write(count);
Console.WriteLine(" раз");