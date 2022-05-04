// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2.     -1, -7, 567, 89, 223-> 3

System.Console.WriteLine("введите числа через запятую");
string s = Console.ReadLine();
string[] array = s.Split(",");//нарезали по запятой
int count = 0;
//первый способ
// for (int i = 0; i < array.Length; i++)
// {
//     int some = int.Parse(array[i]);//преобразовали в числа
//     if (some > 0) count++;
// }
// System.Console.Write($"количество положительных чисел: {count}");

//второй способ
int[] massiv = new int[array.Length];
for (int i = 0; i < massiv.Length; i++)
{
    massiv[i] = Convert.ToInt32(array[i]);
    System.Console.Write(massiv[i] + " ");
    if (massiv[i] > 0) count++;
}
System.Console.WriteLine();
System.Console.WriteLine($"количество положительных чисел: {count}");