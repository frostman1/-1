﻿/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.WriteLine("Ввести число :");
int number_1 = int.Parse(Console.ReadLine());
int number_2 = int.Parse(Console.ReadLine());

if (number_1>number_2) {
    Console.WriteLine($"max - {number_1}");
}
else if(number_1<number_2) {
    Console.WriteLine($"max-{number_2}");
} else  {
    Console.WriteLine ("долбаёб они равны");
}


