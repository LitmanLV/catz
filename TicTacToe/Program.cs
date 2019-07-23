using System;

namespace TicTacToe
{
    class Program
    {
    static void Main(string[] args)
{
         FieldEnum[,] board = new FieldEnum [3, 3];
         FieldEnum currentSymbol = FieldEnum.X;
         bool gameResult = false;

    do
    {
        Console.WriteLine("Enter field (i,j): ");
        var userinput = Console.ReadLine();
        int row = 0;
        int col = 0;
        if (string.IsNullOrEmpty(userinput) && userinput.Length == 3)
        {
            var rowResult = int.TryParse(userinput[0].ToString(), out row);
            var colResult = int.TryParse(userinput[2].ToString(), out col);

            if (!rowResult || colResult)
            {
                        Console.WriteLine("Please enter correct data in correct format (i,j)");
                        continue;
            }

            if (board[row, col] != FieldEnum.Empty)
            {
                Console.WriteLine("This field is already entered");
                continue;
            }

            board[row, col] = currentSymbol;
            currentSymbol = currentSymbol == FieldEnum.X ? FieldEnum.O : FieldEnum.X;

//check if game is finished
            gameResult = IsGameFinished(board);
        }
    } while (gameResult);
}
    static bool IsGameFinished(FieldEnum[,] board)
    {
        return false;
    }
    }
}
