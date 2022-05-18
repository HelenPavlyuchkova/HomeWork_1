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