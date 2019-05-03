using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class Player
    {

        //member variables (HAS A)

        
        public Board attackBoard;
        public Board placeBoard;
        string response;
        int x;
        int y;



        //Constructor (BUILDS OBJECT)


        public Player()
        {
            attackBoard = new Board();
            placeBoard = new Board();
            response = null;
            x = 0;
            y = 0;
        }





       //member methods(CAN DO)

        public void Change()
        {
             attackBoard.gameBoard[14, 14] = "S";
            
        }

        public void Place()
        {
            Console.WriteLine("Place your Submarine");
            response = Console.ReadLine();
            x = int.Parse(response);
            Console.WriteLine("Place your Submarine");
            y = int.Parse(response);
            placeBoard.gameBoard[x, y] = "S";
            placeBoard.gameBoard[x, y - 1] = "S";
            placeBoard.gameBoard[x, y + 1] = "S";
        }






    }
}
