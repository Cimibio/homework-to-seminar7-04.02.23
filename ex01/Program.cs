// Написать программу, которая обменивает элементы первой строки и последней строки

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

void changeMatrix(int[,] arg)
{ 
    {
        int copy = 0;
        for (int i = 0; i < arg.GetLength(1); i++)
        {
                copy = arg[0,i];
                arg[0,i] = arg[arg.GetLength(0)-1,i];
                arg[arg.GetLength(0)-1,i] = copy;
        }
    }
}

FillMatrix(matrix);

PrintMatrix(matrix);

changeMatrix(matrix);

Console.WriteLine();
PrintMatrix(matrix);