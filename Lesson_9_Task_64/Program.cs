// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N.
// M = 6; N = 2. -> "6, 5, 4, 3, 2"
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

void PrintNum(int n, int m)
{
    if (m == n)
    {
        Console.WriteLine(m);
        return;
    }
    else if (m > n)
    {
        System.Console.Write(m + " ");
        PrintNum(n, m - 1);
    }
    else
    {
        System.Console.Write(m + " ");
        PrintNum(n, m + 1);
    }

}

PrintNum(2, 6);
PrintNum(5, 1);
PrintNum(8, 4);

