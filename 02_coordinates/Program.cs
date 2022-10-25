// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

double GetLenghtSegment(double x1, double y1, double z1, double x2, double y2, double z2)       // функция получения длины отрезка
{
    double lenght = 0;
    lenght = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    lenght = Math.Round(lenght, 2);                                                              // для более компактного вывода нашла функцию, которая округляет число до нужного кол-ва знаков
    return lenght;
}

Console.Clear();
Console.Write("Введите коорднату Х 1 числа: ");                                                 // ввод для пользователя
double x1 = Convert.ToDouble(Console.ReadLine() ?? "0");
Console.Write("Введите коорднату Y 1 числа: ");
double y1 = Convert.ToDouble(Console.ReadLine() ?? "0");
Console.Write("Введите коорднату Z 1 числа: ");
double z1 = Convert.ToDouble(Console.ReadLine() ?? "0");

Console.Write("Введите коорднату Х 2 числа: ");
double x2 = Convert.ToDouble(Console.ReadLine() ?? "0");
Console.Write("Введите коорднату Y 2 числа: ");
double y2 = Convert.ToDouble(Console.ReadLine() ?? "0");
Console.Write("Введите коорднату Z 2 числа: ");
double z2 = Convert.ToDouble(Console.ReadLine() ?? "0");


Console.WriteLine($"Расстояние между точками равно {GetLenghtSegment(x1, y1, z1, x2, y2, z2)}");