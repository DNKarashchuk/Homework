// // Задача 4: Напишите программу, которая принимает на вход
//  три числа и выдаёт максимальное из этих чисел.
// // 2, 3, 7 -> 7
// // 44 5 78 -> 78
// // 22 3 9 -> 22

Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (max < numberB) max = numberB;
if (max < numberC) max = numberC;

System.Console.WriteLine("Максимальное из этих чисел: " + max);

// System.Console.Write("max = ");
// System.Console.WriteLine(max);