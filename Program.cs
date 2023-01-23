// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Введите два числа: ");
double A = Convert.ToInt32(Console.ReadLine());
double B = Convert.ToInt32(Console.ReadLine());
double y = 1;
if (B >= 0)
{
    for (int i = 1; i <= B; i++)
    {
        y = y * A;

    }
    Console.WriteLine($"Ответ: {y}");
}
else
{
    y = A;
    for (double i = 0; i >= B; i--)
    {
        y = y / A;

    }
    Console.WriteLine($"Ответ: {y}");
}


