using System;

namespace Tetris
{
    internal class FigureGenerator
    {
        private int x;
        private int y;
        private char c;
        private Random random = new Random();

        public FigureGenerator(int x, int y, char c)
        {
            this.x=x;
            this.y=y;
            this.c=c;
        }

        internal Figure GetNewFigure()
        {
            if (random.Next(0, 2) ==0)
                return new Square(x, y, c);
            else
                return new Stick(x, y, c);

        }
    }
}