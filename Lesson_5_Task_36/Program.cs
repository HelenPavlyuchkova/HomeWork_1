// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих
//на нечётных позициях.

void FillArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(-10, 10);
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

int[] array = new int[6];

FillArray(array);
PrintArray(array);

int sum = 0;
for(int i =0; i < array.Length; i++)
{
    if (i % 2 > 0)
    {
        sum += array[i];
    }
}
System.Console.Write($"Сумма элементов массива на нечётных позициях: {sum}");
