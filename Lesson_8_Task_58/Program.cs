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