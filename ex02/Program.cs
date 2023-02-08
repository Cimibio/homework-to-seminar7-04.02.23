// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

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

void SortMatrix(int[,] arg)
{
    int temp,min;
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            min = arg[i, j];//присваеваем минимальное значение
            for (int sort = j + 1; sort < arg.GetLength(1); sort++)
                if (arg[i, sort] < min)
                {
                    temp = arg[i, sort];
                    arg[i, sort] = min;
                    arg[i, j] = temp;
                    min = temp;
                }
        }
    }
}

void ReverseMatrix(int[,] arg)
{
    int temp,max;
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            max = arg[i, j];        //присваеваем максимальное значение
            for (int sort = j + 1; sort < arg.GetLength(1); sort++)
                if (arg[i, sort] > max)
                {
                    temp = arg[i, sort];
                    arg[i, sort] = max;
                    arg[i, j] = temp;
                    max = temp;
                }
        }
    }
}


FillMatrix(matrix);

PrintMatrix(matrix);

SortMatrix(matrix);

Console.WriteLine("сортировка по возрастанию");
PrintMatrix(matrix);

ReverseMatrix(matrix);

Console.WriteLine("сортировка по убыванию");
PrintMatrix(matrix);