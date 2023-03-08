// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.Clear();
Console.Write("Введите первое число ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число ");
int c = int.Parse(Console.ReadLine()!);

if (b>a)
  a = b;
if(c>a)
  c = a;
Console.Write($"Максимальное число из введённых - {a}");
