// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Введите число А: ");
int number_a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int number_b = Convert.ToInt32(Console.ReadLine());

int result = 1;

for(int i = 0; i < number_b; i++)
{
  result*=number_a;
}

Console.Write($"{number_a},{number_b} -> {result}");