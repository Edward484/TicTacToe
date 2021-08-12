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

        public bool moveIsValid(string moveS)
        {
            int moveI = int.TryParse(moveS);

            

            return true;
        }
    }
}
