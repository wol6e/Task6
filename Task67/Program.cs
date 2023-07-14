// Напишите программу, которая на вход будет принимать число и 
// возвращать сумму его цифр
// 453 -> 12

int number = Prompt("Введите число: ");
Console.WriteLine($"{SumDigit(number)}");

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int SumDigit(int n)
{
    if (n == 0)
    {
        return 0;
    }
    return SumDigit(n / 10) + n % 10;
}


