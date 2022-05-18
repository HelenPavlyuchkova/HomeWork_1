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

//второй способ записи
// if (numi >= m | numj >= n) 
// {
//     Console.WriteLine("в массиве нет такого элемента");
// }
// else
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if(i == numi & j == numj)
//             {
//                 System.Console.WriteLine($"Элемент массива на искомой позиции: {array[i,j]}");
//             }
//         }
//     }
// }
