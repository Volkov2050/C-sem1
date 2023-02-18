Console.Write("Введите номер от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
Console.Write("Monday");
}
else if (number == 2)
{
    Console.Write("Tuesday");
}
else if (number == 3)
{
    Console.Write("Wensday");
}
else if (number == 4)
{
    Console.Write("Thursday");
}
else if (number == 5)
{
    Console.Write("Friday");
}
else if (number == 6)
{
    Console.Write("Saturday");
}
else if (number == 7)
{
    Console.Write("Sunday");
}
else 
{
    Console.Write("Error");
}