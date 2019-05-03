using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class Board
    {

        //member variables (HAS A)
        //string rowA[];
        //string rowB[];
        public string[,] gameBoard;
        public Player player;








        //Constructor (BUILDS OBJECT)
        public Board()
        {
            gameBoard = new string [21, 21];

            for (int i = 0; i < gameBoard.GetUpperBound(0); i++)
            {
                for (int j = 0; j < gameBoard.GetUpperBound(1); j++)
                {
                    gameBoard[i, j] = "O";
                }
            }

            player = new Player();

            //List<List<string>> l = new List<List<string>>();

            //for (int i = 0; i < 20; i++)
            //{
            //    var a = new List<string>() { "0", "0" };

            //    l.Add(a);

            //}
        }


        //member methods(CAN DO)


        public void ShowBoard()
        {
            for (int i = 0; i < gameBoard.GetUpperBound(0); i++)
            {
                for (int j = 0; j < gameBoard.GetUpperBound(1); j++)
                {
                    Console.SetCursorPosition(i*2,j);
                    Console.Write(gameBoard[i,j]);

                   
                }
            } 
        }







    }
}
