using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Snake
{
    internal class Program
    {
        private static SnakeGame snakeGame;
        public static void Main()
        {
            snakeGame = new SnakeGame();
            snakeGame.Run();
        }
    }
}
