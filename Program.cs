// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateArray(int m, int n, int start, int finish)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Random random = new Random();
            array[i, j] = random.Next(start, finish + 1);
        }
    }
    return array;
}


void PrintArray(int[,] array)
{
    Console.Write("[");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ((i != array.GetLength(0) - 1) || (j != array.GetLength(1) - 1))
                Console.Write($"{array[i, j]}; ");
            else
                Console.WriteLine($"{array[i, j]}]");
        }
        Console.WriteLine();
    }
}


Console.Write("Введите количество строк массива m= ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива n= ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начало диапозона start= ");
int start = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите окончание диапазона finish= ");
int finish = Convert.ToInt32(Console.ReadLine());
if (finish < start)
{
    int temp = finish;
    finish = start;
    start = temp;
}


int[,] arr = CreateArray(m, n, start, finish);
PrintArray(arr);
int i, j = 0;
for (j = 0; j < arr.GetLength(1); j++)
{
    double average = 0;
    for (i = 0; i < arr.GetLength(0); i++)
    {
        average += arr[i, j];
    }
    average /= arr.GetLength(0);
    Console.WriteLine($"среднее арифметическое {j+1} столбца: {average.ToString("F2")}");
}
