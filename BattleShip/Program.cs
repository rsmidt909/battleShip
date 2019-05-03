using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game();
            //g.player.board.ShowBoard();
            Console.ReadLine();
            g.player.Place();
            g.player.attackBoard.ShowBoard();
            Console.ReadLine();

        }
    }
}
