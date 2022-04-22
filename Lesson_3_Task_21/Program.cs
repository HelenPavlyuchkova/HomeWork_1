// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int x1 = 7;
int y1 = -5;
int z1 = 0;
int x2 = 1;
int y2 = -1;
int z2 = 9;

double AB = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2) + Math.Pow(z1-z2,2));
AB = Math.Round(AB, 2, MidpointRounding.ToEven);
System.Console.WriteLine($"Расстояние между точками А и В = {AB}");