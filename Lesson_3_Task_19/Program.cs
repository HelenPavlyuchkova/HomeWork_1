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