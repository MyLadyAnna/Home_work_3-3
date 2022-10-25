// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// нужно сравнить 1 и 5 и 2 и 4 цифры числа
Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

int [] array = new int[5];          // массив из 5 элементов
int index = 4;                      
while(index >= 0)
{
    array[index] = number%10;       
    number = number/10;            
    index--;                        
}
if(array[0] == array[4] && array[1] == array[3])
{
    Console.WriteLine($"Число является палиндромом");
}
else 
{
    Console.WriteLine($"Число НЕявляется палиндромом");
}