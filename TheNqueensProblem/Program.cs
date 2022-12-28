internal class Program
{
    private static void Main(string[] args)
    {
        int quenns = int.Parse(Console.ReadLine());
        bool[,] board=new bool[quenns,quenns];

        CreateSolutions(board, 0);
        Console.WriteLine(k);
    }
     static int k=0;
    static void CreateSolutions(bool[,] board, int row)
    {
        if (row>= board.GetLength(0))
        {
            PrintQueens(board);
            k++;
            return;
        }
        for (int i = 0; i < board.GetLength(0); i++)
        {
            if (IsSafe(board,row,i))
            {
                board[row,i] = true;
                CreateSolutions(board,row+1);
            }
            board[row,i] = false;
        }
    }

    private static bool IsSafe(bool[,] board,int row, int col)
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            if (row+i< board.GetLength(0) && board[row+i,col])
            {
                return false;
            }
            if (row-i>=0&& board[row-i,col])
            {
                return false;
            }
            if (col-i>=0 && board[row,col-i])
            {
                return false;
            }
            if (col+i< board.GetLength(0) && board[row,col+i])
            {
                return false;
            }
            if (col + i < board.GetLength(0) &&
                row + i < board.GetLength(0) && board[row + i, col + i])
            {
                return false;
            }
            if (col + i < board.GetLength(0) &&
                row - i >= 0 && board[row - i, col+i])
            {
                return false;
            }
            if (col - i >= 0 && row - i >= 0 &&
                board[row - i, col - i])
            {
                return false;
            }
            if (col - i >= 0 &&
                row + i < board.GetLength(0) && board[row + i, col - i])
            {
                return false;
            }
        }
        return true;
    }

    private static void PrintQueens(bool[,] board)
    {
        for (int row = 0; row < board.GetLength(0); row++)
        {
            for (int col = 0; col < board.GetLength(0); col++)
            {
                if (board[row,col])
                {
                    Console.Write(" Q ");
                }
                else
                {
                    Console.Write(" _ ");
                }
                    
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}