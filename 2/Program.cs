
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22     

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
// 1.Сравнить три числа между собой.
// 2.Найти максимальное число из трёх.

if (a > b)
{
    Console.Write($"max {a}");
}
else if (b > c)
{
    Console.Write($"max {b}");
}
else if (c > a)
{
    Console.Write($"max {c}");
}
else
{
    Console.Write("Условия не соблюдены");
}





