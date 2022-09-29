// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 100) Console.WriteLine("Третьей цифры нет");
else{
int TheThirdNum (int num)
  {
    while (num >= 1000)
    {
        num = num / 10;
    }
    int third = num%10;
    return third;
  }

    Console.WriteLine($"Третья цифра: {TheThirdNum(a)}");
}