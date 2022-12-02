/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
int max = 0, min = 0;

Console.Write("a = ");
int numA = int.Parse(Console.ReadLine());

Console.Write("b = ");
int numB = int.Parse(Console.ReadLine());


if (numA > numB) {
    max = numA;
    min = numB;
    Console.WriteLine("numA > numB");
} else if (numA < numB) {
    max = numB;
    min = numA;  
    Console.WriteLine("numB > numA");
} else {
    Console.WriteLine("numB = numA");
}