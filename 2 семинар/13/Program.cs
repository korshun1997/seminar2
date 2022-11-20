// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int result = 0;
int f = 0;
int ThirdDig(int N, int result)
{
while (N>999)
    {
        N = N / 10;
    }
    result = N % 10;
    return result;
}
if (N<100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    f = ThirdDig(N, result);
    Console.WriteLine($"Третья цифра числа равна {f}");
}

