// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
System.Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int sum = 0;
while(N > 0)
{
    int newN = N % 10;//получили цифру, крайнюю справа 
    sum += newN;
    N = N / 10;//отсекли крайнюю справа цифру
}
System.Console.WriteLine($"Сумма цифр указанного числа равна: {sum}");

