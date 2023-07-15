// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
double[,] FillMatrix(int row, int col, int leftRange=-10, int righRange=100 )
{
    double[,] tempMatrix = new double[row, col];
    Random rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = Math.Round(rand.Next(leftRange, righRange) + rand.NextDouble(), 1);
        }
    }
    return tempMatrix;
}

void PrintMatrix(double[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i,j]+" \t ");// тубуляция "\t"
        }
        System.Console.WriteLine();//tabulyacia
    }
}

//~~~~~~~~~~~~~~~~~~~~~~~~`
int rows=ReadInt("введите кол-во строк: ");
int cols=ReadInt("введите кол-во столбцов: ");
double[,] matrix =FillMatrix(rows, cols);
System.Console.WriteLine();
PrintMatrix(matrix);