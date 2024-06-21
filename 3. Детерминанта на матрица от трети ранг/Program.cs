using System;

class Program
{
    static void Main()
    {
        int[,] matrix = new int[3, 3];
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter row {i + 1} separated by space: ");
            int[] row = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int j = 0; j < 3; j++)
            {
                matrix[i, j] = row[j];
            }
        }

        int determinant = Determinant(matrix);
        Console.WriteLine($"Determinant: {determinant}");
    }

    static int Determinant(int[,] matrix)
    {
        return matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1])
             - matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0])
             + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
    }
}
