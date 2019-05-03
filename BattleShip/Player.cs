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

        Board board;






        //Constructor (BUILDS OBJECT)


        public Player()
        {
            board = new Board();
        }





       //member methods(CAN DO)

        public void Change()
        {
             board.gameBoard[2, 4] = "S";
        }


        



    }
}
