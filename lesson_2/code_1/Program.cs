/*
Задача 10: Напишите программу, 
которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int number = int.Parse(Console.ReadLine());

int num_2 = (number / 10) % 10;
int num_3 = (number / 100) % 10;

if (num_3 > 0) { // если число трехзначное
    Console.WriteLine(num_2);
} else {
    Console.WriteLine("error");
}
