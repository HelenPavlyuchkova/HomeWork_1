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