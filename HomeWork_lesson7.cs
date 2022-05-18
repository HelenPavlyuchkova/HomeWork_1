// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int m = 3;
int n = 4;

void FillArray(double[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i,j] = Convert.ToDouble(new Random().Next(-100,100)) / 10;
        }
    }
}
void PrintArray(double[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write($"{mass[i,j]} ");
        }
    Console.WriteLine();
    }
Console.WriteLine();
}

// второй вариант
// Random random = new Random();
// void FillArray(double[,] mass)
// {
//     for (int i = 0; i < mass.GetLength(0); i++)
//     {
//         for (int j = 0; j < mass.GetLength(1); j++)
//         {
//             mass[i,j] = random.NextDouble() * 10 - 7;
//         }
//     }
// }
// void PrintArray(double[,] mass)
// {
//     for (int i = 0; i < mass.GetLength(0); i++)
//     {
//         for (int j = 0; j < mass.GetLength(1); j++)
//         {
//             Console.Write($"{Math.Round(mass[i,j],1)} ");
//         }
//     Console.WriteLine();
//     }
// Console.WriteLine();
// }
double[,] array = new double[m,n];
FillArray(array);
PrintArray(array);



// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
//возвращает значение этого элемента или же указание, что такого элемента нет.

int m = 6;
int n = 5;

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " "); ;
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);

// int numi = 2;
// int numj = 4;
System.Console.Write("введите номер строки: ");
int numi = int.Parse(Console.ReadLine()!);
System.Console.Write("введите номер столбца: ");
int numj = int.Parse(Console.ReadLine()!);

if (numi < m & numj < n) 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i == numi & j == numj)
            {
                System.Console.WriteLine($"Элемент массива на искомой позиции: {array[i,j]}");
            }
        }
    }
}
else
{
    Console.WriteLine("в массиве нет такого элемента");
}



// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

int m = 5;
int n = 4;

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " "); ;
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);

double[] sum = new double [n];
for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum[i] += array[j,i];
        }
    }
for (int i = 0; i < sum.Length; i++)
{
    Console.Write(sum[i] / m + " ");
}    

