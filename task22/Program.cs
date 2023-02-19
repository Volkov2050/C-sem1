// Напишите программу, которая принимает на вход число
// (N) и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// System.Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// for(int i = 1; i <= number; i++)// i = i + 2
// {
// System.Console.Write($"{Math.Pow(i, 2)} ");
// }

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i <= N)
{
    System.Console.Write($"{Math.Pow(i, 2)} ");
    i++;
}
