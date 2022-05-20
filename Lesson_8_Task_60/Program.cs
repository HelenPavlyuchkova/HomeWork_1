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
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int k = 1; k < array.GetLength(2); k++)
//         {
//            Console.Write(array[i, j, k] + " "); 
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// void FillArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 array[i, j, k] = new Random().Next(10, 100);
//             }
//         }
//     }
// }
// void PrintArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write(array[i, j, k] + " ");
//             }
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void PrintArrInd(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]}[{i},{j},{k}]" + " ");
//             }
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// int[,,] array = new int[a, b, c];
// FillArray(array);
// PrintArray(array);
// System.Console.WriteLine("массив с индексами элементов");
// PrintArrInd(array);

