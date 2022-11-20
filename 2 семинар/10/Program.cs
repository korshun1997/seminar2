// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трёхзначное число");
int N = Convert.ToInt32(Console.ReadLine());
int m=0;
int f=0;
int SecondDigit(int m, int N)
{
      m = (N / 10) % 10;
      return m;
}
if (N>1000 || N<100)
{
    Console.WriteLine("Ошибка! Введите  трёхзначное число");
}
else
{
    f = SecondDigit(m, N);
    Console.WriteLine($"Вторая цифра {f}" );
}