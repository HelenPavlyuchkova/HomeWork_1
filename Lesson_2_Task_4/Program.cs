// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
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