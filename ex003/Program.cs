// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.WriteLine("Какой сейчас по счету день недели?");
int day = Convert.ToInt32(Console.ReadLine());
if(day < 8 && day > 0)
{
  if(day > 5)
  Console.WriteLine("Этот день выходной.");
  else
  Console.WriteLine("Этот день не выходной.");
}
else
  Console.WriteLine("Такого дня не бывает!");
