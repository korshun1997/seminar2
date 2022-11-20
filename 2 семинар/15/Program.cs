// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число от 1 до 7");
int N = Convert.ToInt32(Console.ReadLine());
string m = "день недели";
string f = "день недели";
string Days(int N, string m)
{
        if (N>5)
    {
        m = "Выходной";
    } 
else
{
    m = "Будний день";
}
return m;
}
if (N>7 || N<1)
{
    Console.WriteLine("Ошибка! Введите число от 1 до 7");
}
else
{
    f = Days(N, m);
    Console.WriteLine($"Этот день - {f}");
}