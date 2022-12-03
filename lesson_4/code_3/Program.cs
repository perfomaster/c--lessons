/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и
 выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int N = int.Parse(Console.ReadLine());

int[] arr = fillArray(N);
showArray(arr);


int[] fillArray (int n) {
    int[] array = new int[n];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++) {
        array[i] = random.Next(0, 100);
    }
    return array;
}

void showArray (int[] array) {
    for (int i = 0; i < array.Length; i++) {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
}