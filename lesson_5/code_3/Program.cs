/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
Не использовать готовые методы Min и Max

[3 7 22 2 78] -> 76
*/

Random random = new Random();
double[] array = new double[int.Parse(Console.ReadLine())];
double result = 0, min = Double.MaxValue, max = Double.MinValue;
for (int i = 0; i < array.Length; i++) {
    array[i] = random.Next();
    
    Console.WriteLine(array[i]);
    if (array[i] < min) {
        min = array[i];
    }
    if (array[i] > max) {
        max = array[i];
    }
}
result = max - min;
Console.WriteLine(result);
