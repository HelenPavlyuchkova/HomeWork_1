// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

void FillArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(100, 1000);//100,..999
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

int count = 0;
for (int j = 0; j < array.Length; j++)
{
    if(array[j] % 2 == 0)
    {
        count = count + 1;
    }
}
System.Console.Write($"количество чётных чисел в массиве: {count}");