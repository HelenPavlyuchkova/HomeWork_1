// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
System.Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.Write("введите число В: ");
int B = int.Parse(Console.ReadLine());

double num = 1;
for(int i = 1; i <= B; i++)
{
    num = Math.Pow(A, i);
}
System.Console.WriteLine(num);



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



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void FillArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(1, 100);
    }
}

void PrintArray(int[] arr)
{
    for (int index = 0; index < arr.Length; index++)
    {
        Console.Write($"{arr[index]} ");
    }
    Console.WriteLine();
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);
