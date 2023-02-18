//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//456 -> 6
//782 -> 2
//918 -> 8
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int lastNumber = 0;
if (number > 99 && number < 1000)
{
    lastNumber = number%10;
    Console.Write(lastNumber);
}
else
{
    Console.Write("Некорректный ввод");
}
