/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и
 проверяет, является ли оно палиндромом.
  Задание должно быть выполнено в методе. 
  В методе не должно быть вывода в консоль. 
  Не использовать String!
14212 -> нет
12821 -> да
23432 -> да
*/

int num5 = int.Parse(Console.ReadLine());

int checking = PalindromCheck(num5);
if (checking >= 0) {
    if (checking == 1) {
        Console.WriteLine($"{num5} is palindrom");
    } else {
        Console.WriteLine($"{num5} is not palindrom");
    }
} else if (checking == -1) {
    Console.WriteLine("error");
}

int PalindromCheck (int input) {
    int num_1 = input % 10;
    int num_2 = (input / 10) % 10;
    int num_3 = (input / 100) % 10;
    int num_4 = (input / 1000) % 10;
    int num_5 = (input / 10000) % 10;
    int n_5 = (input / 10000);
    if ( n_5 < 10 && n_5 > 0) {
        if (num_1 == num_5 && num_2 == num_4) {
            return 1;
        } else {
            return 0;
        }
    } else {
        return -1;
    }
}