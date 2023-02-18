Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int temp = -number;
while (temp <= number)
{
    Console.Write($"{temp} ");
    temp++; // temp = temp +1
}