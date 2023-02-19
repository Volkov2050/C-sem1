// // Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// // причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int Promt(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

string Quaters(int X, int Y)
{
    string result = " ";
    if (X > 0 && Y > 0)
    {
        result = "Точка в 1 четверти";
    }
    else if (X < 0 && Y > 0)
    {
        result = "Точка вo 2 четверти";
    }
    else if (X < 0 && Y < 0)
    {
        result = "Точка в 3 четверти";
    }
    else if (X > 0 && Y < 0)
    {
        result = "Точка в 4 четверти";
    }
    else
    {
        result = "X и Y не могут равняться 0";
    }
    return result;
}

int X = Promt ("Введите Х координату: ");
int Y = Promt ("Введите Y координату: ");

string quater = Quaters(X, Y);

System.Console.WriteLine(quater);