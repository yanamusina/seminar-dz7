// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
            System.Console.Write(matrixForPrint[i, j] + " \t");// тубуляция "\t"
        }
        System.Console.WriteLine();//tabulyacia
    }
}

void NewPrintMatrix(int[,] matrixForPrint)
{
   {
    int row = ReadInt("Введите номер строки матрицы: ");
    int col = ReadInt("Введите номер столбца матрицы: ");
    if (row <= matrixForPrint.GetLength(0) && col <= matrixForPrint.GetLength(1))
    {
        System.Console.WriteLine($"Элемента по введённым данным: {matrixForPrint[row, col]} ");
            }
    else
    {
        System.Console.WriteLine($"такого числа в массиве нет");
    }
}
}
    //~~~~~~~~~~~~~~~~~~~~~~~~`
    int rows = ReadInt("введите кол-во строк: ");
    int cols = ReadInt("введите кол-во столбцов: ");
    int[,] matrixForPrint = FillMatrix(rows, cols, 0, 9);
    System.Console.WriteLine();
    PrintMatrix(matrixForPrint);
    System.Console.WriteLine();
    NewPrintMatrix(matrixForPrint);
