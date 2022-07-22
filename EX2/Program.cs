// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей 
//суммой элементов.
Console.WriteLine("Чтобы матрица была прямоугольный введите разные числа ");
int m = IntNum("Введите число m: ");
int n = IntNum("Введите число n: ");

int[,] matrix = new int[m, n];
NewMatrix(matrix);
PrintMatrix(matrix);
int line = 0;
int min = 0;
int sum = sumElement(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
    line = sumElement(matrix, i);
    if (sum > line)
    {
        sum = line;
        min = i;
    }
}

Console.WriteLine($"\n{min + 1} - строкa с наименьшей суммой ({sum}) элементов ");


int sumElement(int[,] matrix, int i)
{
    int sum = matrix[i, 0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        sum += matrix[i, j];
    }
    return sum;
}

int IntNum(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void NewMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}



