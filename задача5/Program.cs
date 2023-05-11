// Напишите программу, которая принимает на вход два числа 
// и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8, 9  ->  нет

Console.WriteLine("Введите число");
int nam1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int nam2 = Convert.ToInt32(Console.ReadLine());

if (nam1 == nam2 * nam2 || nam2 == nam1 * nam1)
{
    Console.WriteLine("Одно число является квадратом другого");    
}
else
{
    Console.WriteLine("Не является");
}