namespace Saper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowCount = 5;
            int ColumnCount = 5;
            bool[,] mineField = new bool[rowCount, ColumnCount];

            PrintBoard(mineField);

            while (true)
            {
                Console.WriteLine("Bitte Feld eingeben: ");
                var field = Console.ReadLine();

                if (field == "q")
                {
                    break;
                }

                UncoverField(mineField, field);
                PrintBoard(mineField);
            }
        }

        static void PrintBoard(bool[,] board)
        {
            Console.WriteLine("   A  B  C  D  E");

            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.Write($"{i + 1}  ");

                for (int k = 0; k < board.GetLength(1); k++)
                {
                    if (!board[i, k])
                    {
                        Console.Write("X  ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }

                Console.WriteLine();
            }
        }

        static void UncoverField(bool[,] board, string field)
        {
            var rowChar = field.Substring(0, 1);
            var row = (int)char.Parse(rowChar);
            row -= 65;

            var colChar = field.Substring(1);
            var col = int.Parse(colChar);
            col -= 1;

            board[row, col] = true;
        }
    }
}