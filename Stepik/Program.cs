using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Stepik
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Renderer renderer = new Renderer();
            Player player = new Player(55, 10);

        }
    }

    class Renderer
    {
        public void Draw(int x, int y, char character = '@')
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(x, y);
            Console.Write(character);
            Console.ReadKey(true);
        }
    }

    class Player
    {
        public int X;
        public int Y;

        public Player(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    
   
}









