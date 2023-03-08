// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.WriteLine("Введите число");
int border = Convert.ToInt32(Console.ReadLine());
if (border>=2)
{
  int a = 2;
  while (a <= border)
  {
    Console.Write($"{a} ");
    a=a+2;
  }
}
else if (border <= -2)
{
  int a = 0;
  while (a >= border)
  {
    Console.Write($"{a} ");
    a=a-2;
  }
}
else
Console.Write("Удовлетворяющих условию чисел не найдено");