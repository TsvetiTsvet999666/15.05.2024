namespace Plates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][][] document = new int[n][][];
            for (int i = 0; i < n; i++)
            {
                string[] dimensions = Console.ReadLine().Split();
                int rows = int.Parse(dimensions[0]);
                int cols = int.Parse(dimensions[1]);

                document[i] = new int[rows][];
                for (int row = 0; row < rows; row++)
                {
                    document[i][row] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                }
            }
            double[] minValues = new double[n];
            double[] maxValues = new double[n];
            double[] sumValues = new double[n];
            double totalSum = 0;
            for (int i = 0; i < n; i++)
            {
                double sum = 0;
                minValues[i] = maxValues[i] = document[i][0][0];
                foreach (var row in document[i])
                {
                    foreach (var num in row)
                    {
                        sum += num;
                        minValues[i] = Math.Min(minValues[i], num);
                        maxValues[i] = Math.Max(maxValues[i], num);
                    }
                }
                sumValues[i] = sum / (document[i].Length * document[i][0].Length);
                totalSum += sumValues[i];
            }
            double globalAverage = totalSum / n;
            int[] aboveAverageCount = new int[n];
            for (int i = 0; i < n; i++)
            {
                foreach (var row in document[i])
                {
                    foreach (var num in row)
                    {
                        if (num > globalAverage)
                        {
                            aboveAverageCount[i]++;
                        }
                    }
                }
            }
            Console.WriteLine("Sheet statistics:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{minValues[i]:F2} {maxValues[i]:F2} {sumValues[i]:F2}");
            }

            Console.WriteLine(string.Join(" ", aboveAverageCount));
        }
    }
}
