// Задайте двумерный массив. Найдите сумму 
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1,1) и т.д.)
// Например, задан массив:
// 1 4 7 2 
// 5 9 2 3
// 8 4 2 4
// Cумма элементов главной диагонали: 1+9+2 =12

int rows = Prompt("Введите количество строк: ");
int columns = Prompt("Введите количество столбцов: ");
int minValue = Prompt("Введите число минимального диапазона: ");
int maxValue = Prompt("Введите число максимального диапазона: ");

int[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);
int res = 0;
Sumnum(array);
Console.WriteLine($"Сумма элементов главной диагонали {res}");

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m,n];
    for(int i=0; i<m; i++)
    {
        for(int j = 0; j<n; j++)
        {
            result[i,j] = new Random().Next(min,max);
            //Console.Write($"{result[i,j]}  ");
        }
       //Console.WriteLine();
    }
    return result;
}

int Sumnum(int[,] array)
{
    int res = 0;
    for(int i=0; i<array.GetLength; i++)
    {
        for(int j = 0; j<array.GetLength; j++)
        {
            if(i ==j)
            {
                res = res + array[i,j];
            }
        }
    }
    return res;
}

void PrintArray(int[,] arr)
{
    for (int i =0; i<arr.GetLength(0); i++)  // длина строк
    {
        for(int j=0; j<arr.GetLength(1); j++)    // длина столбцов
        {
            Console.Write(arr[i,j]+ " ");
        }
        Console.WriteLine();
    }
}