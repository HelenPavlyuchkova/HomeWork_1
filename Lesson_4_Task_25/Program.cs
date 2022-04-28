// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
System.Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.Write("введите число В: ");
int B = int.Parse(Console.ReadLine());

double num = 1;
for(int i = 1; i <= B; i++)
{
    num = Math.Pow(A, i);
}
System.Console.WriteLine(num);
