// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 99)
{
  string n = Convert.ToString(number);
  Console.WriteLine($"Третья цифра числа: {n[2]}");
}
else
  Console.WriteLine("Третей цифры нет");