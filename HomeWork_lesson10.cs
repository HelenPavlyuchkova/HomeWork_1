// Есть число N. Сколько групп M, можно получить при разбиении всех
// чисел на группы, так чтобы в одной группе все числа были взаимно просты (все
// числа в группе друг на друга не делятся)? Найдите M при заданном N и получите
// одно из разбиений на группы N ≤ 10²⁰.
// Например, для N = 50, M получается 6

void PrintGroups(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        if (massiv[i, 0] == 0)
        {
            Console.Write($"Всего групп: {i}");
            break;
        }
        Console.Write($"Группа {i + 1}: ");
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            if (massiv[i, j] == 0)
                break;
            Console.Write(massiv[i, j] + " ");
        }
        Console.WriteLine();
    }
}
bool Check(int x, int y)
{
    return (x % y == 0 || y % x == 0);
}

int N = 50;
int[,] array = new int[N, N];

int l = 0;

for (int i = 1; i <= N; i++)
{
    for (int k = 0; k < array.GetLength(1); k++)
    {
        if (array[l, k] == 0)
        {
            array[l, k] = i;
            l = 0;
            break;
        }
        else if (Check(i, array[l, k]))
        {
            l++;
            k = -1;
            continue;
        }
    }
}
PrintGroups(array);