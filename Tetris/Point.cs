using System;

namespace Tetris
{
    public class Point
    {
        public int X { get; set; }

        public int Y { get; set; }

        public char C { get; set; }

        public Point(int x, int y, char c)
        {
            X =x;
            Y =y; 
            C =c; 
        }


        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(C);
        }
    }
}
