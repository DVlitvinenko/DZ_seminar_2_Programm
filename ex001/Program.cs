// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 99 && number < 1000)
{
  int n = (number / 10) % 10;
  Console.WriteLine($"Вторая цифра числа: {n}");
}
else
  Console.WriteLine("Число не трехзначиное");
