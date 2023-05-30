// Домашнее задание
//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//       A (3,6,8); B (2,1,-7), -> 15.84
//       A (7,-5, 0); B (1,-1,9) -> 11.53

//Вводим А(X1,Y1,Z1)-ПЕРВАЯ ТОЧКА
Console.Write("Введите координату по оси X1: ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по оси Y1: ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по оси Z1: ");
int Z1 = Convert.ToInt32(Console.ReadLine());
//Вводим В(X2,Y2,Z2)-ВТОРАЯ ТОЧКА
Console.Write("Введите координату по оси X2: ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по оси Y2: ");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по оси Z2: ");
int Z2 = Convert.ToInt32(Console.ReadLine());
//Нахождение расстояние между 2-мя точками (теорема Пифагора)
double d = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 -Z1, 2));
Console.WriteLine($"Расстояние между точками А:({X1},{Y1},{Z1}) и B:({X2},{Y2},{Z2})) равно: {Math.Round(d,2)}");