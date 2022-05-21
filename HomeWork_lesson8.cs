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

int maxval, temp = 0;
int maxi, maxj;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        maxval = array[i, j];
        maxi = i;
        maxj = j;
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



// Задача 58: Задайте две матрицы. Напишите программу, которая будет
//находить произведение двух матриц.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);
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

int m1 = 3;
int n1 = 4;
int m2 = 4;
int n2 = 5;
if (n1 != m2)
{
    Console.WriteLine($"Матрицы не совместимы,т.к. {n1} не равно {m2}");
    return;
}
int[,] matrix1 = new int[m1, n1];
int[,] matrix2 = new int[m2, n2];
int[,] matrixMult = new int[m1, n2];
FillArray(matrix1);
PrintArray(matrix1);
FillArray(matrix2);
PrintArray(matrix2);
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int k = 0; k < matrix2.GetLength(1); k++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)//кол-во столбцов 1й матрицы = кол-ву строк 2й
        {
            matrixMult[i, k] = matrixMult[i, k] + matrix1[i, j] * matrix2[j, k];
        }
    }
}
PrintArray(matrixMult);



// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

int a = 4;
int b = 4;
int c = 4;

int[,,] array = new int[a,b,c];
int[] save = new int[array.Length];
bool exist = false;
int count = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            array[i, j, k] = new Random().Next(10, 100);
            exist = false;
            for (int l = 0; l < count; l++)
            if(array[i,j,k] == save[l])
            {
                exist = true;
                k--;
                break;
            }
           if (exist == false)
            {
                Console.Write($"{array[i, j, k]}[{i},{j},{k}]" + " ");
                save[count] = array[i,j,k];
                count++; 
            }
        }
    }
    System.Console.WriteLine();
}

