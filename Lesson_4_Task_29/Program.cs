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
