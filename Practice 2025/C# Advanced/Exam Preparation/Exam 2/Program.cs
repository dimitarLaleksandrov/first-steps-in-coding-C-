using System.ComponentModel;

namespace Exam_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = int.Parse(Console.ReadLine());
            char[,] matrix = new char[matrixSize, matrixSize];

            for (int row = 0; row < matrixSize; row++) 
            {
               var currentRow = Console.ReadLine().Replace(" ", string.Empty).ToCharArray();
                for (int col = 0; col < currentRow.Length; col++) 
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            var blackTruffle = 0;
            var summerTruffle = 0;
            var whiteTruffle = 0;
            var eatanTrufels = 0;

            var command = Console.ReadLine();

            while (command != "Stop the hunt") 
            {
                var commandName = command.Split()[0];
                var row = int.Parse(command.Split()[1]);
                var col = int.Parse(command.Split()[2]);

                switch (commandName)
                {
                    case "Collect":
                        
                        if (matrix[row, col] == 'B' || matrix[row, col] == 'S' || matrix[row, col] == 'W')
                        {
                            char truffle = matrix[row, col];
                            matrix[row, col] = '-';
                            switch (truffle)
                            {
                                case 'B':

                                    blackTruffle++;
                                    break;
                                case 'S':

                                    summerTruffle++;
                                    break;
                                case 'W':

                                    whiteTruffle++;
                                    break;

                                default:
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine($"Ther is No Truffels to find in thet position");
                        }

                        break;

                    case "Wild_Boar":

                        var direction = command.Split()[3];
                        var wildBoar = matrix[row, col];
                        switch (direction)
                        {
                            case "up":
                                while (IsValidRow(row, matrixSize))
                                {
                                    if(EatBoar(row, col, matrix))
                                    {
                                        Printmatrix(matrix);
                                        eatanTrufels++;
                                    }

                                    row -= 2;
                                }
                                break;
                            case "down":
                                while (IsValidRow(row, matrixSize))
                                {
                                    if (EatBoar(row, col, matrix))
                                    {
                                        Printmatrix(matrix);
                                        eatanTrufels++;
                                    }

                                    row += 2;
                                }
                                break;
                            case "left":
                                while (IsValidCol(col, matrixSize))
                                {
                                    if (EatBoar(row, col, matrix))
                                    {
                                        Printmatrix(matrix);
                                        eatanTrufels++;
                                    }

                                    col -= 2;
                                }
                                break;
                            case "right":
                                while (IsValidCol(col, matrixSize))
                                {
                                    if (EatBoar(row, col, matrix))
                                    {
                                        Printmatrix(matrix);
                                        eatanTrufels++;
                                    }

                                    col += 2;
                                }
                                break;

                            default:
                                break;
                        }

                        break;


                    default:
                        break;
                }
                
                command = Console.ReadLine();
            }

            Console.WriteLine($"Peter manages to harvest {blackTruffle} black, {summerTruffle} summer, and {whiteTruffle} white truffles.");
            Console.WriteLine($"The wild boar has eaten {eatanTrufels} truffles.");
            Printmatrix(matrix);




        }

        public static void Printmatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col > 0)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }


        public static bool IsValidRow(int row, int size)
        {
            return row >= 0 && row < size;
        }
        public static bool IsValidCol(int col, int size)
        {
            return col >= 0 && col < size;
        }

        public static bool EatBoar(int row, int col, char[,] matrix)
        {
            var charSymbol = matrix[row, col];

            if (charSymbol == 'B' || charSymbol == 'S' || charSymbol == 'W')
            {
                matrix[row, col] = '-';
                return true;
            }

            return false;
        }
    }
}
