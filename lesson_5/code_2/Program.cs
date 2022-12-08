/*
Задача 36: Задайте одномерный массив, 
заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных индексах.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/


Random random = new Random();
int[] array = new int[int.Parse(Console.ReadLine())];
int result = 0;
for (int i = 0; i < array.Length; i++) {
    array[i] = random.Next();
    
    Console.WriteLine(array[i]);
    if ((i % 2) != 0) {
        result += array[i];
    }
}
Console.WriteLine();
Console.WriteLine(result);
