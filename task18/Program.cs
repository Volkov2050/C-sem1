//Напишите программу, которая по заданному номеру четверти,
//показывает диапазон возможных координат точек в этой четверти (x и y).

// int Promt (string message)
// {
//     System.Console.WriteLine(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// string Quaters (int x)
// {
//     string result = " ";
//     if (x == 1)
//     {
//         result = "Значение Х > 0, Y > 0";
//     }
//     else if (x == 2)
//     {
//         result = "Значение Х < 0, Y > 0";
//     }
//     else if (x == 3)
//     {
//         result = "Значение Х < 0, Y < 0";
//     }    
//     else if (x == 4)
//     {
//         result = "Значение Х > 0, Y < 0";
//     }
//     else
//     {
//         result = "Некорректное значение";
//     }    
//     return result;
// }

// int X = Promt ("Введите номер четверти от 1 до 4");

// string quater = Quaters(X);

// System.Console.WriteLine(quater);

int Promt(string message)
{
Console.Write(message);
int result = Convert.ToInt32(Console.ReadLine());
return result;
}

bool Checked(int quater)
{
    if(quater >= 1 && quater <= 4)
    {
        return true;
    }
    else
    {
        return false;
    }
}

string[] quaters ={"x > 0; y > 0", "x < 0; y > 0", "x < 0; y < 0", "x > 0; y < 0"};

int quater = Promt("Введите четверть: ");

if(Checked(quater))
{
Console.Write(quaters[quater - 1]);
}
else
{
Console.Write("Неправильный номер четверти");
}