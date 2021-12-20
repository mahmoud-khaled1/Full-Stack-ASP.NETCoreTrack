using System;
// By :Mahmoud Khaled 
namespace Tic_Tac_toe_game
{
    public static class Global
    {
        public static int X = 4;

    }
    class Program
    {

        static void DrowWallsFirstTime()
        {
            for (int i = 0; i < Global.X; i++)
            {
                for (int k = 0; k <= Global.X; k++)
                {
                    if (k == 0)
                    {
                        Console.Write("|   ");
                    }
                    else if (k == Global.X)
                    {
                        Console.WriteLine("|");
                    }
                    else
                    {
                        Console.Write("||   ");
                    }
                }
            }
        }
        static bool CheckIfPlayerWin(char[,] mat,char Player)
        {
            //check Rows
            int sumRow = 0;
            for (int i = 0; i < Global.X; i++)
            {
                for (int j = 0; j < Global.X; j++)
                {
                    if (mat[i, j] == Player)
                        sumRow++;
                }
                if (sumRow == Global.X)
                {
                    return true;
                }
                sumRow = 0;
            }
            //check columns
            int sumCol = 0;
            for (int i = 0; i < Global.X; i++)
            {
                for (int j = 0; j < Global.X; j++)
                {
                    if (mat[j, i] == Player)
                        sumCol++;
                }
                if (sumCol == Global.X)
                {
                    return true;
                }
                sumCol = 0;
            }
            //check Diagonal from Left to right 
            int sumDiagonalLeft = 0;
            for (int i = 0; i < Global.X; i++)
            {
                for (int j = 0; j < Global.X; j++)
                {
                    if (i==j && mat[j, i] == Player)
                        sumDiagonalLeft++;
                }
            }
            if (sumDiagonalLeft == Global.X)
                return true;

            //Check Diagonal From right to left
            int sumDiagonalRight = 0;
            int column = Global.X - 1;
            for (int i = 0; i < Global.X; i++)
            {
                if (mat[i, column] == Player)
                {
                    sumDiagonalRight++;
                    column--;
                }

            }
            if (sumDiagonalRight == Global.X)
                return true;

            return false;

        }
        static void PrintMatrix(char[,] matrix)
        {
            //Print The Matrix 
            int wall = 0;
            for (int i = 0; i < Global.X ; i++)
            {
                for (int j = 0; j < Global.X ; j++)
                {
                    if (wall == 0)
                        Console.Write("| " + matrix[i, j]);
                    else if (wall == Global.X - 1)
                    {
                        Console.Write(" || " + matrix[i, j]);
                        Console.Write(" |");
                    }
                    else 
                        Console.Write(" || " + matrix[i, j]);
                    wall++;
                }
                wall = 0;
                Console.WriteLine();
            }
        }
        static bool CheckIfInputIsCorrect(int row ,int col)
        {
            if ((row >= 0 && row <= Global.X-1) && (col >= 0 && col <= Global.X - 1))
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
            int changePlayer = 0;
            // Get Input from user as string that contain Row and Column
            string position = "";
            //Create Matrix x*x and initilized it with . 
            char[,] matrix = new char[Global.X, Global.X];
            for (int i = 0; i < Global.X; i++)
            {
                for (int j = 0; j < Global.X; j++)
                {
                    matrix[i, j] = '.';
                }
            }

            int row = 0;
            int col = 0;
            bool running = true;
            //Running The Console untile Player Win
            while (running)
            {
                // if ChangePlayer is even then player X will play .
                if (changePlayer % 2 == 0)
                {
                    //Get Row and Column from User and convert it to int 
                    Console.WriteLine("Enter X Position:");
                    position = Console.ReadLine();
                    row = position[0] - '0';
                    col = position[2] - '0';
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
                                Console.Clear();
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("X is Wins");
                                Console.ResetColor();
                                running = false;
                            }
                            else
                                Console.Clear();
                            //Print The Matrix 
                            PrintMatrix(matrix);

                            //Change Player From 'X' To 'O'
                            changePlayer++;
                        }
                    }
                }
                else
                {
                    //Get Row and Column from User and convert it to int
                    Console.WriteLine("Enter O Position:");
                    position = Console.ReadLine();
                    row = position[0] - '0';
                    col = position[2] - '0';
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
                                Console.Clear();
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("O is Wins");
                                Console.ResetColor();
                                running = false;
                            }
                            else
                                Console.Clear();
                            //Print The Matrix 
                            PrintMatrix(matrix);
                            //Change Player From 'O' To 'X'
                            changePlayer++;
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
