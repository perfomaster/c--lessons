/*
Задача 13: Напишите программу, 
которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет. Не использовать string[]
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
int number = int.Parse(Console.ReadLine());

int num_3 = (number / 100) % 10;

if (num_3 > 0) { // если число трехзначное
    Console.WriteLine(num_3);
} else {
    Console.WriteLine("error");
}