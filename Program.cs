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
            mainManager game = new mainManager(10, 1, 1);
            game.startGame();
        }
    }
}
