/*
Задача 25: Напишите программу, которая принимает на вход 
два числа (A и B) и метод который
 возводит число A в натуральную степень B. 
 Задание должно быть выполнено в методе. 
 В методе не должно быть вывода в консоль. 
 Не использовать Math.Pow()
*/

int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());

Console.WriteLine(mathPow(A, B));

int mathPow (int a, int b) {
    int index = 0, result = a;
    
    while (index < b - 1) {
        result *= (int)a;
        index += 1;
    }
    return result;
}