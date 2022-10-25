// Напишите программу, которая принимает на вход число (N) и выдает таблицу простых чисел от 1 до N.

bool IsPrimeNumb(int number)        // функция на проверку простого числа
{
    if(number == 1)                // 1 - не простое число
    return false;

    for(int i=2; i < number; i++)       // проверяем простое ли число 
    {
        if(number % i == 0) return false;
    }
    return true;                        
}

Console.Clear();
Console.Write("Введите число: ");
int result;
if(!int.TryParse(Console.ReadLine(), out result) || (result < 0))       // если число будет введено не интовое либо отрицательное
{
    Console.WriteLine("Введите целое положительное число");
}

for(int i = 1; i <= result; i++)
{
    if (IsPrimeNumb(i))                         // функция возвращает true - выводим число, false - не выводим
    {
        Console.Write($"{i}, ");
    }
}









