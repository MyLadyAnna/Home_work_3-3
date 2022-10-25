// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void PrintCubesNumbers(double number)
{
    double count = 1;
    double cube = 0;
    while (count <= number)
    {

        cube = Math.Pow(count, 3);
        Console.Write($"{cube}, ");
        count++;
    }
    return;
}

Console.Clear();
Console.Write("Введите число: ");
double number = Convert.ToDouble(Console.ReadLine() ?? "0");

PrintCubesNumbers(number);