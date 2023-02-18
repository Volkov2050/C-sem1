
Console.Write("Введите номер задачи (2,4,6,8): ");
int HW = Convert.ToInt32(Console.ReadLine());

switch (HW)
{

case 2:

// Напишите программу, которая на вход принимает 
// два числа и выдает, какое число большее, а какое меньшее.

Console.Write("Введите число 1 ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2 ");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (number1 > number2)
{
    max = number1;
    System.Console.WriteLine(max);
}
else if (number1 < number2)
{
    max = number2;
    System.Console.WriteLine(max);
}
else
{
    System.Console.WriteLine("Числа равны");
}
break;

case 4:

//Напишите программу, которая принимает на вход 
//три числа и выдает максимальное из этих чисел.

Console.Write("Введите число 1 ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2 ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3 ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max2 = num1;
if (max2 > num2)
{
    if (max2 > num3)
    {
        System.Console.WriteLine(max2);
    }
    else
    {
        max2 = num3;
        System.Console.WriteLine(max2);
    }
}
else if (num2 > num3)
{
    max2 = num2;
    System.Console.WriteLine(max2);
}
else
{
    max2 = num3;
    System.Console.WriteLine(max2);
}
break;

case 6:

//Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number%2 == 0)
{
    System.Console.WriteLine("Yes");
} 
else
{
    System.Console.WriteLine("No");
}
break;

case 8:

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int temp = 2;
while (temp <= N)
{
    Console.Write($"{temp} ");
    temp = temp + 2; // temp = temp +1
}
break;

default:
System.Console.WriteLine("Некорректное число");
break;
}