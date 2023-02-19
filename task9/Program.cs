// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//Например:
//78 -> 8
//12-> 2
//85 -> 8


int number = new Random().Next(10,100);
System.Console.WriteLine($"Ваше случайное число: {number}");

int digit1 = number/10;
int digit2 = number%10;

if (digit1 > digit2)
{
    System.Console.WriteLine($"Наибольшее цифра числа: {digit1}");
}
else if (digit1 < digit2)
{
    System.Console.WriteLine($"Наибольшее цифра числа: {digit2}");
}
else 
{
    System.Console.WriteLine("Числа равны");
}