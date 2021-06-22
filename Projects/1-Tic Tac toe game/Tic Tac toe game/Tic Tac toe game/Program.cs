using System;
// By :Mahmoud Khaled 
namespace Tic_Tac_toe_game
{
    class Program
    {
        static void DrowWallsFirstTime()
        {
            string Walls = "|   ||   ||   |\n|   ||   ||   |\n|   ||   ||   |";
            Console.WriteLine(Walls);
        }
        static bool CheckIfPlayerWin(char[,] mat,char Player)
        {
            //check Rows
            int SumRow = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (mat[i, j] == Player)
                        SumRow++;
                }
                if (SumRow == 3)
                {
                    return true;
                }
                SumRow = 0;
            }
            //check columns
            int SumCol = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (mat[j, i] == Player)
                        SumCol++;
                }
                if (SumCol == 3)
                {
                    return true;
                }
                SumCol = 0;
            }
            //check Diagonal
            if (mat[0, 0] == Player && mat[1, 1] == Player&& mat[2, 2] == Player)
            {
                return true;
            }
            if (mat[0, 2] == Player && mat[1, 1] ==Player && mat[2, 0] == Player)
            {
                return true;
            }
            return false;
        }
        static void PrintMatrix(char[,] matrix)
        {
            //Print The Matrix 
            int wall = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (wall == 0)
                        Console.Write("| " + matrix[i, j]);
                    else if (wall == 1)
                        Console.Write(" || " + matrix[i, j]);
                    else if (wall == 2)
                    {
                        Console.Write(" || " + matrix[i, j]);
                        Console.Write(" |");
                    }
                    wall++;
                }
                wall = 0;
                Console.WriteLine();
            }
        }
        static bool CheckIfInputIsCorrect(int row ,int col)
        {
            if ((row >= 0 && row <= 2) && (col >= 0 && col <= 2))
                return true;
            else
                return false;
        }
        static bool CheckIfPositionIsOccupedOrNot(char[,]mat,int row,int col)
        {
            if (mat[row, col] != '.')
                return true;
            else
                return false;
        }
        static void RunGame()
        {
            //if ChangePlayer is even then 'X' will play other 'O'
            int ChangePlayer = 0;
            // Get Input from user as string that contain Row and Column
            string Position = "";
            //Create Matrix 3x3 and initilized it with . 
            char[,] matrix = new char[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = '.';
                }
            }

            int row = 0;
            int col = 0;
            bool Running = true;
            //Running The Console untile Player Win
            while (Running)
            {
                // if ChangePlayer is even then player X will play .
                if (ChangePlayer % 2 == 0)
                {
                    //Get Row and Column from User and convert it to int 
                    Console.WriteLine("Enter X Position:");
                    Position = Console.ReadLine();
                    row = Position[0] - '0';
                    col = Position[2] - '0';
                    //Check If Input Is Correct
                    if (!CheckIfInputIsCorrect(row, col))
                    {
                        Console.WriteLine("Invalid Input Try Again !");
                    }
                    else
                    {
                        //Check If Position Is Occuped Or Not
                        if (CheckIfPositionIsOccupedOrNot(matrix, row, col))
                        {
                            Console.WriteLine("This Position is Occuped Try Again !");
                        }
                        else
                        { 
                            matrix[row, col] = 'X';
                            //Check if PLayer 'X' is Win or not 
                            if (CheckIfPlayerWin(matrix, 'X'))
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("X is Wins");
                                Console.ResetColor();
                                Running = false;
                            }
                            //Print The Matrix 
                            PrintMatrix(matrix);

                            //Change Player From 'X' To 'O'
                            ChangePlayer++;
                        }
                    }
                }
                else
                {
                    //Get Row and Column from User and convert it to int
                    Console.WriteLine("Enter O Position:");
                    Position = Console.ReadLine();
                    row = Position[0] - '0';
                    col = Position[2] - '0';
                    //Check If Input Is Correct
                    if (!CheckIfInputIsCorrect(row, col))
                    {
                        Console.WriteLine("Invalid Input Try Again !");
                    }
                    else
                    {
                        //Check If Position Is Occuped Or Not
                        if (CheckIfPositionIsOccupedOrNot(matrix, row, col))
                        {
                            Console.WriteLine("This Position is Occuped Try Again !");
                        }
                        else
                        {
                            matrix[row, col] = 'O';
                            //Check if PLayer 'O' is Win or not 
                            if (CheckIfPlayerWin(matrix, 'O'))
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("O is Wins");
                                Console.ResetColor();
                                Running = false;
                            }
                            //Print The Matrix 
                            PrintMatrix(matrix);
                            //Change Player From 'O' To 'X'
                            ChangePlayer++;
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //Note For User  
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Note : Enter Position in Format --> position of Row,Position Of Column\nexample => 0,1");
            Console.ResetColor();
            Console.WriteLine();

            //Drow The Wall First Time 
            DrowWallsFirstTime();
            
            //Start The Game 
            RunGame();

            Console.ReadLine();
        }
    }
}
