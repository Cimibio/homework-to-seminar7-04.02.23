//В прямоугольной матрице найти строку с наименьшей суммой элементов.

Console.Write("Введите количество строк матрицы: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[m,n];

void PrintMatrix(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            Console.Write($" {arg[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillMatrix(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            arg[i,j] = new Random().Next(1,10);
        }
    }
}

int ShowMinMatrixRow(int[,] arg)
{ 
    int result = 1;
    int sum = 0;
    int min = 0;
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            sum = sum + arg[i,j];
            if (i == 0) min = sum;

        }
        if (min > sum)
        {
            min = sum;
            result = i + 1;
        }
        sum = 0;
    }
    return result;
}

FillMatrix(matrix);

PrintMatrix(matrix);

Console.WriteLine();

Console.WriteLine($"Номер строки с минимальной суммой элементов: {ShowMinMatrixRow(matrix)}");