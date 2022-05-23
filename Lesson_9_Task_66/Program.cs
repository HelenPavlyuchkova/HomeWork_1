// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = 4, N = 8;

int RecSum(int n, int m)
{
    if(m > n)
        return 0;
    System.Console.Write(m + " ");
    return RecSum(n, m+1) + m;
}

int summa = RecSum(N,M);
System.Console.WriteLine();
System.Console.Write($"Сумма натуральных элементов в промежутке от {M} до {N}: ");
System.Console.WriteLine(summa);


