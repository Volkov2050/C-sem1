Console.Write("Введите номер задачи (10,13,15): ");
int HW = Convert.ToInt32(Console.ReadLine());

switch (HW)
{

case 10:

// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает 
// вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

System.Console.WriteLine("Введите трехзначное число: ");
int number10 = Convert.ToInt32(Console.ReadLine());

if (number10 > 99 && number10 < 1000)
{
    int result10 = number10%100/10;
    System.Console.WriteLine(result10); 
}
else 
{
    System.Console.WriteLine("Некорректное число");
}
break;

case 13:

//Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

System.Console.WriteLine("Введите число: ");
int number13 = Convert.ToInt32(Console.ReadLine());
int result13 = 0;
if (number13 < 100)
{
    System.Console.WriteLine("Третья цифра отсутствует");
}
else 
{
    while (number13 > 999)
    {
        number13 /= 10;
        
    }
    result13 = number13%10;
    System.Console.WriteLine($"Третье цифра вашего числа: {result13}");
}
break;


case 15:


//Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

System.Console.WriteLine("Введите цифру от 1 до 7: ");
int number15 = Convert.ToInt32(Console.ReadLine());
if (number15 >= 1 && number15 <= 5)
{
    System.Console.WriteLine("No");
}
else if (number15 >= 6 && number15 <= 7)
{
    System.Console.WriteLine("Yes");
}
else
{
    System.Console.WriteLine("Некорректный ввод");
}
break;

default:
System.Console.WriteLine("Некорректное число");
break;
}