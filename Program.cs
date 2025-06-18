using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sensorsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuManager game = new MenuManager(1, 6);
            game.startGame();
        }
    }
}
