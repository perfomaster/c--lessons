/*
Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

Random random = new Random();
int[] array = new int[int.Parse(Console.ReadLine())];
int result = 0;
for (int i = 0; i < array.Length; i++) {
    array[i] = random.Next(100, 1000);
    
    Console.WriteLine(array[i]);
    if ((array[i] % 2) == 0) {
        result++;
    }
}
Console.WriteLine();
Console.WriteLine(result);

