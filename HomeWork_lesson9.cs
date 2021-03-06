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



// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.


int m = 2, n = 3;
int A(int m1, int n1)
{
    if (n1 < 0 || m1 < 0) return 0;
    else if (m1 == 0) return n1 + 1;
    else if (n1 == 0 && m1 > 0) return A(m1 - 1, 1);
    return A(m1 - 1, A(m1, n1 - 1));
}

int akkerman = A(m,n);

Console.Write($"Значение функции Аккермана A({m}, {n}) равна: ");
Console.WriteLine(akkerman);