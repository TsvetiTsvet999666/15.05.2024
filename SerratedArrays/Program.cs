namespace SerratedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int columns = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, columns];
            Console.WriteLine("Enter the elements of the matrix:");
            for (int i = 0; i < rows; i++)
            {
                string[] rowElements = Console.ReadLine().Split();
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = int.Parse(rowElements[j]);
                }
            }
            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < columns - 1; j++)
                {
                    int currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }
            Console.WriteLine("Max 2x2 submatrix:");
            Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]}");
            Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]}");
        }
    }
}
