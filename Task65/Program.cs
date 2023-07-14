// Задайте числа M и N. Напишите программу, которая выведет все 
// натуральные числа от M до N
// M = 4, N = 8 -> 4,5,6,7,8

Console.WriteLine("Введите большее значение n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите меньшее значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"{Range(n,m)}");

string Range(int n, int m)
{
    if(n==m)
    {
        return m.ToString();
    }
    return Range(n-1, m) + "," + n;
}
