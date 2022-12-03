/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и
 находит расстояние между ними в 3D пространстве. 
 Задание должно быть выполнено в методе.
 В методе не должно быть вывода в консоль.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.WriteLine("A: ");
Console.Write("x=");
int X_A = int.Parse(Console.ReadLine());
Console.Write("y=");
int Y_A = int.Parse(Console.ReadLine());
Console.Write("z=");
int Z_A = int.Parse(Console.ReadLine());
Console.WriteLine("B: ");
Console.Write("x=");
int X_B = int.Parse(Console.ReadLine());
Console.Write("y=");
int Y_B = int.Parse(Console.ReadLine());
Console.Write("z=");
int Z_B = int.Parse(Console.ReadLine());

double dist = distance3D(X_A, Y_A, Z_A, X_B, Y_B, Z_B);
string result = string.Format("{0:f2}", dist);
Console.WriteLine(result);

double distance3D (int X_A, int Y_A, int Z_A, int X_B, int Y_B, int Z_B) {
    return Math.Sqrt(Math.Pow(X_B - X_A, 2) + Math.Pow(Y_B - Y_A, 2) + Math.Pow(Z_B - Z_A, 2));
}