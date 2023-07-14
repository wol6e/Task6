// Задайте натуральное число N. Напишите программу, которая выведет все 
// натуральные числа от 1 до N
// N = 5 -> 1,2,3,4,5

int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{Range(n)}");

string Range(int n)
{
    if(n==1)
    {
        return "1";
    }
    return Range(n-1) + "," + n;
}
