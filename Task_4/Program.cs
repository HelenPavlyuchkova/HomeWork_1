// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int a = 22;
int b = 3;
int c = 9;
int max = a;
if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;
Console.WriteLine($"Максимальное из чисел {a} {b} {c}");
Console.Write("max = ");
Console.WriteLine(max);