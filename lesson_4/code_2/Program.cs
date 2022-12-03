/*
Задача 27: Напишите программу, которая принимает на вход число и
 выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

int number = int.Parse(Console.ReadLine());

bool flag = true;
int index = 0, result = 0;

while (flag) {
    int num = (int)(number / Math.Pow(10, index)) % 10;
    if ((number / Math.Pow(10, index)) < 10) {
        flag = false;
    }
    result += num;
    index += 1;
}

Console.WriteLine(result);

