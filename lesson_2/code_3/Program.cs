/*
Задача 15: Напишите программу, 
которая принимает на вход цифру, 
обозначающую день недели, и проверяет, 
является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

int number = int.Parse(Console.ReadLine());

if (number > 5 && number < 8) {
    Console.WriteLine("Weekend");
} else if (number > 0 && number < 6) {
    Console.WriteLine("Weekdays");
}