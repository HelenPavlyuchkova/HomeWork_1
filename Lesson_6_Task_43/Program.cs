// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем. 
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

System.Console.WriteLine("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
double x, y;
if (k1!=k2)
{
    x = (b2 - b1)/(k1 - k2); 
    y = k1 * x + b1; 
    //y = (k1 * (b2 - b1)/(k1 - k2)) + b1;
    System.Console.WriteLine($"координаты точки пересечения х = {Math.Round(x, 2)}, y = {Math.Round(y, 2)}");
}
else 
{
    System.Console.WriteLine("прямые не пересекаются");// параллельны или совпадают
}
