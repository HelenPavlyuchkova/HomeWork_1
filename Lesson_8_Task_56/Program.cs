// Задача 56: Задайте прямоугольный двумерный массив. Напишите
//программу, которая будет находить строку с наименьшей суммой элементов.

int m = 4;
int n = 3;

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
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

int mini = 0;
int min = int.MaxValue;

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    System.Console.Write(sum + " ");
    
    if (sum < min)
    {
        min = sum;
        mini = i;
    }
}
System.Console.WriteLine();
System.Console.WriteLine($"Номер строки с наименьшей суммой элементов: {mini}");


