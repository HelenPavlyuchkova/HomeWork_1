// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру
Console.Clear();
int a, b, c;
int num = new Random().Next(100, 1000); //100, 101,..., 999
System.Console.WriteLine($"Трёхзначное число: {num}");

a = num / 100;
b = num % 10;
c = 10 * a + b;
Console.WriteLine($"Искомое число: {c}");



// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99)
{
    while(number > 999)
    {
        number = number / 10;
    }
    number = number % 10;
    Console.WriteLine($"Третья цифра числа: {number}");
} 
else
{
    Console.WriteLine("Третьей цифры нет");
}



// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру, обозначающую день недели, от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());

if ((day == 6) | (day == 7))
{
    Console.WriteLine("выходной");
}
else if((day == 1) | (day == 2) | (day == 3) | (day == 4) | (day == 5))
{
    Console.WriteLine("Будний день");
}
else
{
    Console.WriteLine("указанная цифра не является днём недели:) ");
}