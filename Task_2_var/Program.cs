// Задача 2(второй вариант решения): Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int a = -3;
int b = -9;

if(a > b) 
{
    Console.Write("max = ");
    Console.WriteLine(a);
    Console.WriteLine($"min = {b}");
}
else
{
    Console.Write("max = ");
    Console.WriteLine(b);
    Console.WriteLine($"min = {a}");
}
