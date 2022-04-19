// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру
Console.Clear();
int a, b, c;
int num = new Random().Next(100, 1000); //100, 101,..., 999
System.Console.WriteLine($"Трёхзначное число: {num}");

a = num / 100;
b = num % 10;
c = 10 * a + b;
Console.WriteLine($"Искомое число: {c}");

