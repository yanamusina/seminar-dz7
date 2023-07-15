// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3
int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int[,] FillMatrix(int row, int col, int leftRange, int righRange)
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, righRange + 1);
        }
    }
    return tempMatrix;
}

void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "\t ");// тубуляция "\t"
        }
        System.Console.WriteLine();//tabulyacia
    }
}

double[] NumberMatrix (int[,] matrix)
{
    double[] number = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            number[j] += matrix[i, j];
        }
        number[j] /= matrix.GetLength(0);;
    }
    return number;
}
void PrintArray(double[] array)
{
    System.Console.WriteLine($"Среднее арифметическое каждого столбца:{string.Join (" ",array)}");
}


//~~~~~~~~~~~~~~~~~~~~~~~~`
int rows = ReadInt("введите кол-во строк: ");
int cols = ReadInt("введите кол-во столбцов: ");
int[,] matrix = FillMatrix(rows, cols, 0, 9);
PrintMatrix(matrix);
double[] number=NumberMatrix(matrix);
PrintArray(number);