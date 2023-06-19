// // Написать программу
// Console.WriteLine("Hello, World!");
 
//  4 -> 16;
//  -3 -> 9;
//  -7 -> 49;

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int quater = number * number;
Console.WriteLine($"Квадрат числа {number} равен {quater}");
