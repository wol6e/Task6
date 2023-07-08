// Задайте двумерный массив. Найдите элементы,
// у которых оба индекса чётные, и замените эти 
// элементы на квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2 
// 5 81 2 9
// 8 4 2 4
// Новый массив будет вглядеть:
// 1 4 7 2 
// 5 9 2 3
// 8 4 2 4

int rows = Prompt("Введите количество строк: ");
int columns = Prompt("Введите количество столбцов: ");
int minValue = Prompt("Введите число минимального диапазона: ");
int maxValue = Prompt("Введите число максимального диапазона: ");

int[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);
Console.WriteLine();
int[,] newArray = NewArray(array);
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

int[,] NewArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i=i+2)
    {
        for(int j=0; j<array.GetLength(1); j=j+2)
        { 
            array[i,j] = array[i,j]*array[i,j];
        }
    }
    return array;
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