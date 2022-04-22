// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
System.Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
System.Console.Write("Таблица кубов: ");

while(i < N)
{
    System.Console.Write($"{Math.Pow(i,3)}, ");
    i++;
}
System.Console.WriteLine($"{Math.Pow(i,3)}.");
