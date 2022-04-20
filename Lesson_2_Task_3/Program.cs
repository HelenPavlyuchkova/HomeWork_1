// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99)
{
    while(number > 999)
    {
        number = number / 10;
    }
    number = number % 10;
    Console.WriteLine($"Третья цифра числа: {number}");
} 
else
{
    Console.WriteLine("Третьей цифры нет");
}

// if((number > 99) & (number <= 999))
// {
//     System.Console.WriteLine((number % 100) % 10);
// }
// else if((number > 999) & (number <= 9999))
// {
//     System.Console.WriteLine((number % 100) / 10);
// }
// else if((number > 9999) & (number <= 99999))
// {
//     System.Console.WriteLine((number / 100) % 10);
// }
// else if((number > 99999) & (number <= 999999))
// {
//     System.Console.WriteLine((number / 1000) % 10);
// }
// else
// {
//     System.Console.WriteLine("В указанном числе третьей цифры нет!");
// }