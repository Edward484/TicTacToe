using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class TicTacToe
    {
        string[,] board = new string[,]
        {
            {"1","2","3"},
            {"4","5","6"},
            {"7","8","9"}
        };
        bool gameFinished;
        string currentMove;

        public TicTacToe()
        {
            gameFinished = false;
            currentMove = "x";
        }


        //returns "null" if game not yet finished
        public string checkWin()
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == "x" && board[i, 1] == "x" && board[i, 2] == "x")
                    return "x";
                if (board[0, i] == "x" && board[1, i] == "x" && board[2, i] == "x")
                    return "x";
            }
            if (board[0, 0] == "x" && board[1, 1] == "x" && board[2, 2] == "x")
                return "x";
            if (board[0, 2] == "x" && board[1, 1] == "x" && board[2, 0] == "x")
                return "x";
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == "o" && board[i, 1] == "o" && board[i, 2] == "o")
                    return "o";
                if (board[0, i] == "o" && board[1, i] == "o" && board[2, i] == "o")
                    return "o";
            }
            if (board[0, 0] == "o" && board[1, 1] == "o" && board[2, 2] == "o")
                return "o";
            if (board[0, 2] == "o" && board[1, 1] == "o" && board[2, 0] == "o")
                return "o";

            return "null";
        }

        public bool newMove(string moveS)
        {
            try
            {
                int moveI;
                bool succes = Int32.TryParse(moveS, out moveI);
                if (succes == false)
                    throw new InvalidCastException();
                if (succes)
                {
                    if(moveI >0 && moveI < 9)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                if (moveS == board[i,j])
                                {
                                    board[i,j] = currentMove;
                                    return true;
                                }

                            }
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Input must be between 0 and 9", nameof(moveI)); 
                    }
                }
            }
            catch(InvalidCastException e)
            {
                Console.WriteLine("You have to give as an input a number from 1 to 9. Try again! ");
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            return false ;
        }

        public void printBoard()
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"|  {board[i, j]}  |");
                }
                Console.WriteLine();
                Console.WriteLine("---------------------");
            }
        }

        public void changeTurns()
        {
            if (currentMove == "x")
                currentMove = "o";
            else
                currentMove = "x";
        }

        public void gameRunning()
        {
            if (gameFinished == false)
            {
                printBoard();
                Console.WriteLine($"It is {currentMove}'s turn. Please input a number from 0 to 9: ");
                var input = Console.ReadLine();
                if (newMove(input))
                {
                    var status = checkWin();
                    if (status != "null")
                    {
                        gameFinished = true;
                        printBoard();
                        Console.WriteLine($"Player {status} has won");
                    }
                    else
                    {
                        changeTurns();
                    }

                }
            }
        }
    }
}
