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



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным
//элементов массива.

void FillArray(double[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(0, 100);
    }
}

void PrintArray(double[] arr)
{
    for (int index = 0; index < arr.Length; index++)
    {
        Console.Write($"{arr[index]} ");
    }
    Console.WriteLine();
}

double MaxVal(double[] massiv)
{
    double result = massiv[0];
    for (int i = 0; i < massiv.Length; i++)
    {
        if (massiv[i] > result) result = massiv[i];
    }
    return result;
}

double MinVal( double[] mass)
{
    double res = mass[0];
    for (int i = 0; i < mass.Length; i++)
    {
       if (mass[i] < res) res = mass[i];
    }
    return res;
}

double[] massiv = new double[8];

FillArray(massiv);
PrintArray(massiv);
double max = MaxVal(massiv);
System.Console.WriteLine($"max элемент: {max}");

double min = MinVal(massiv);
System.Console.WriteLine($"min элемент: {min}");

System.Console.WriteLine($"Разница между ними: {max - min}");




//второй вариант решения(на примере массива целых числел):
// void FillArray(int[] col)
// {
//     for (int i = 0; i < col.Length; i++)
//     {
//         col[i] = new Random().Next(1, 10);
//     }
// }

// void PrintArray(int[] arr)
// {
//     for (int index = 0; index < arr.Length; index++)
//     {
//         Console.Write($"{arr[index]} ");
//     }
//     Console.WriteLine();
// }

// int[] array = new int[8];

// FillArray(array);
// PrintArray(array);

// int max = array[0];
// int min = array[1];
// for(int i = 0; i < array.Length; i++)
// {
//     if(array[i] > max) max = array[i];
//     if(array[i] < min) min = array[i];
// }
// System.Console.WriteLine(max);
// System.Console.WriteLine(min);
// System.Console.WriteLine($"{max - min}");