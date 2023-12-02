using System;

class Program
{
    static void Main()
    {
        // 1 завдання багатовимірних масивів
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int diagonalSum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            diagonalSum += matrix[i, i];
        }


        Console.WriteLine(" Сума елементiв по головнiй дiагоналi: " + diagonalSum);

        // 2 завдання багатовимірних масивів
        int[,] amatrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine(" Введiть номер стовпця для обчислення добутку його елементiв:");
        int columnToMultiply = Convert.ToInt32(Console.ReadLine());

        int columnProduct = CalculateColumnProduct(amatrix, columnToMultiply - 1);

        if (columnProduct != -1)
        {
            Console.WriteLine("Добуток елементiв стовпця " + columnToMultiply + ": " + columnProduct);
        }
        else
        {
            Console.WriteLine("Ви ввели некоректний номер стовпця.");
        }

        static int CalculateColumnProduct(int[,] amatrix, int columnIndex)
        {
            if (columnIndex < 0 || columnIndex >= amatrix.GetLength(1))
            {
                return -1;
            }

            int product = 1;
            for (int i = 0; i < amatrix.GetLength(0); i++)
            {
                product *= amatrix[i, columnIndex];
            }
            return product;
        }

        // 3 завдання багатовимірних масивів
        int[,] bmatrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine(" Початкова матриця:");
        PrintMatrix(bmatrix);

        int[,] rotatedMatrix = RotateMatrixCounterClockwise(bmatrix);

        Console.WriteLine("Матриця пiсля обертання на 90 градусів проти годинникової стрілки:");
        PrintMatrix(rotatedMatrix);


        static int[,] RotateMatrixCounterClockwise(int[,] bmatrix)
        {
            int n = bmatrix.GetLength(0);
            int[,] rotatedMatrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    rotatedMatrix[n - 1 - j, i] = bmatrix[i, j];
                }
            }

            return rotatedMatrix;
        }

        static void PrintMatrix(int[,] bmatrix)
        {
            int n = bmatrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(bmatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}