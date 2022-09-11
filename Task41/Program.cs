// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 5
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void CountPositiveNumbers()
{
    Console.Write("Сколько чисел будет введено: ");
    Console.WriteLine();
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Вводите числа: ");
    int count = 0;
    for (int i = 0; i < M; i++)
    {
        int x = Convert.ToInt32(Console.ReadLine());
        if (x > 0) count++;
    }
    Console.WriteLine($"Из введенных чисел больше нуля {count}");
}
CountPositiveNumbers();