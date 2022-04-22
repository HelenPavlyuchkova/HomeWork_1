// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
Console.Clear();
System.Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());

int a = num / 100;
int b = num % 100;
int c = a / 10;

if((num < 9999) | (num > 99999))
{
    System.Console.WriteLine("Заданное число не пятизначное");
}
else if((b / 10 == c % 10) & (b % 10 == c / 10))
{
    System.Console.WriteLine("Указанное число - палиндром");
}
else
{
    System.Console.WriteLine("Указанное число НЕ является палиндромом");
}


// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int x1 = 7;
int y1 = -5;
int z1 = 0;
int x2 = 1;
int y2 = -1;
int z2 = 9;

double AB = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2) + Math.Pow(z1-z2,2));
AB = Math.Round(AB, 2, MidpointRounding.ToEven);
System.Console.WriteLine($"Расстояние между точками А и В = {AB}");


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