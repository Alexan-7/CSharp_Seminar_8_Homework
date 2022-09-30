/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива. */

Console.Clear();

int height = EnterInt("Введите количество строк: ");
int width = EnterInt("Введите количество столбцов: ");

int[,] numbers = new int[height, width];
Fill2DArray(numbers);
Print2DArray(numbers);
Console.WriteLine("\nУпорядочим по убыванию элементы каждой строки двумерного массива: ");
SortInDescending(numbers);
Print2DArray(numbers);

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

void Fill2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(-20, 21);
        }
    }
}

void Print2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)      // для каждой строки
    {
        for (int j = 0; j < numbers.GetLength(1); j++)   // внутри этой строки для каждого столбца
        {
            Console.Write($"{numbers[i, j],3} ");
        }
        Console.WriteLine();
    }    
}

void SortInDescending(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            for (int k = 0; k < numbers.GetLength(1) - 1; k++)
            {
                if (numbers[i, k] < numbers[i, k + 1])
                {
                    int temp = numbers[i, k + 1];
                    numbers[i, k + 1] = numbers[i,k];
                    numbers[i, k] = temp;
                }
            }
        }
    }
}