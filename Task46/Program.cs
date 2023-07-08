// Задайте двухмерный массив m,n, заполненный случайными целыми числами
// m =3, n =4
// 1 4 8 19 
// 5 -2 33 -2
// 77 3 8 1

int rows = Prompt("Введите количество строк: ");
int columns = Prompt("Введите количество столбцов: ");
int minValue = Prompt("Введите число минимального диапазона: ");
int maxValue = Prompt("Введите число максимального диапазона: ");

int[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);

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