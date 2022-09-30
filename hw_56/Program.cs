/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов. */

Console.Clear();

int height = EnterInt("Введите количество строк: ");
int width = EnterInt("Введите количество столбцов: ");

int[,] numbers = new int[height, width];
Fill2DArray(numbers);
Print2DArray(numbers);
SumInLines(numbers);

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

void SumInLines(int[,] numbers)
{
    int[] sumInLines = new int[numbers.GetLength(0)];
    Console.Write("\nСуммы элементов в каждой строке: ");
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            sumInLines[i] += numbers[i, j];
        }
        Console.Write($"{sumInLines[i]} ");
    }
    int minI = 0;
    for (int i = 0; i < sumInLines.Length; i++)
    {
        if (sumInLines[minI] > sumInLines[i]) minI = i;
    }
    Console.Write($"\nНаименьшая сумма элементов: {sumInLines[minI]}, номер строки с ней: {minI + 1}");
}