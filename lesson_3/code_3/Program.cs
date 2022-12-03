/*
Задача 23
Напишите программу, которая принимает на вход число (N) и
 выдаёт таблицу кубов чисел от 1 до N. 
 Задание должно быть выполнено в методе и 
 метод должен вернуть массив чисел.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.Write("N=");
int N = int.Parse(Console.ReadLine());
int[] result = new int[N];
result = writeCube(N);
for (int i = 0; i < result.Length; i++) {
    if (i < result.Length - 1) Console.Write($"{result[i]}, ");
    else Console.Write(result[i]);
}
int[] writeCube(int input) {
    int[] arr = new int [input];
    int index = 0;
    while (index < input) {
        arr[index] = (int)Math.Pow(index + 1, 3);
        index += 1;
    }
    return arr;
}
