// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1


Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(100 <= num & num <= 999) 
{
    int x = num / 10;
    int y = x%10;
   
    Console.WriteLine($"Вторая цифра числа: {y}");
}
else  Console.WriteLine("Ошибка! Введите трёхзначное число");

