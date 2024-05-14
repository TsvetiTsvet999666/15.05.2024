using System.Reflection;

namespace SeaChess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] board = new char[3, 3];
            Console.WriteLine("Enter the configuration of the Tic-Tac-Toe board:");
            for (int i = 0; i < 3; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = input[j];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] != '-' && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    Console.WriteLine($"Winner: {board[i, 0]}");
                    return;
                }
            }
            for (int j = 0; j < 3; j++)
            {
                if (board[0, j] != '-' && board[0, j] == board[1, j] && board[1, j] == board[2, j])
                {
                    Console.WriteLine($"Winner: {board[0, j]}");
                    return;
                }
            }
            if (board[0, 2] != '-' && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                Console.WriteLine($"Winner: {board[0, 2]}");
                return;
            }
        }    
    }
}
