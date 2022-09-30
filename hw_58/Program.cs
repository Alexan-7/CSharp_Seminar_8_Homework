// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();

int height1 = EnterInt("Введите количество строк в первой матрице: ");
int width1 = EnterInt("Введите количество столбцов в первой матрице: ");
int height2 = EnterInt("Введите количество строк во второй матрице: ");
int width2 = EnterInt("Введите количество столбцов во второй матрице: ");

int[,] numbers1 = new int[height1, width1];
int[,] numbers2 = new int[height2, width2];
int[,] resultNumbers = new int[height2, width1];

Fill2DArray(numbers1);
Print2DArray(numbers1);
Console.WriteLine();

Fill2DArray(numbers2);
Print2DArray(numbers2);
Console.WriteLine();

if (numbers1.GetLength(1) != numbers2.GetLength(0))
{
    Console.Write("Такие матрицы нельзя перемножить, поскольку количество столбцов ");
    Console.Write("первой матрицы не равно количеству строк второй матрицы");
    return;  // почему return работает без функции и ничего не возвращает???
}

for (int i = 0; i < numbers1.GetLength(0); i++)
{
    for (int j = 0; j < numbers2.GetLength(1); j++)
    {
        resultNumbers[i, j] = 0;
        for (int k = 0; k < numbers1.GetLength(1); k++)
        {
            resultNumbers[i, j] += numbers1[i, k] * numbers2[k, j];
        }
    }
}
Console.WriteLine("Произведение этих матриц: ");
Print2DArray(resultNumbers);

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

void Fill2DArray(int[,] numbers1)
{
    for (int i = 0; i < numbers1.GetLength(0); i++)
    {
        for (int j = 0; j < numbers1.GetLength(1); j++)
        {
            numbers1[i, j] = new Random().Next(-10, 11);
        }
    }
}

void Print2DArray(int[,] numbers1)
{
    for (int i = 0; i < numbers1.GetLength(0); i++)
    {
        for (int j = 0; j < numbers1.GetLength(1); j++)
        {
            Console.Write($"{numbers1[i, j],5}");
        }
        Console.WriteLine();
    }
}