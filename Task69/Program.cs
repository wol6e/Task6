// Напишите программу, которая на вход принимает два числа A и B и
// djpdjlbn число A в целую степень B с помощью рекурсии
// A = 3, B = 5 -> 245

int a = Prompt("Введите число: ");
int b = Prompt("Введите степень числа b: ");
Console.WriteLine($"{Pow(a, b)}");

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

//int Pow(int A, int B)
//{
    //if (B == 0)
    //{
        //return 1;
    //}
    //int temp = Pow(A,B/2);
    //int temp2 = (B % 2 == 1)? A: 1;
    //return temp * temp * temp2;
//}

int Pow(int A,int B)
{
    if(B == 0)
    {
        return 1;
    }
    return Pow(A, B-1) * A;
}


