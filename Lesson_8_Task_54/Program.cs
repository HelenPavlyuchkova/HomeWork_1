// Задача 54: Задайте двумерный массив. Напишите программу, которая
//упорядочит по убыванию элементы каждой строки двумерного массива.

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

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int maxval = array[i, j];
        int temp = 0;
        int maxi = i, maxj = j;//индексы максимального эл-та
        for (int k = j; k < array.GetLength(1); k++)
        {
            if(array[i,k] > maxval)
            {
                maxval = array[i,k];
                maxi = i;
                maxj = k;
            }
        }
        temp = array[i,j];
        array[i,j] = array[maxi,maxj]; 
        array[maxi,maxj] = temp;
    }
}

PrintArray(array);

