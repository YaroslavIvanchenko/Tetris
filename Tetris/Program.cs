using System;

namespace Tetris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            //var s = new Square(2, 5, '*');
            //s.Draw();


            //var stick = new Stick(2, 5, '*');
            //stick.Draw();

            //Point p1 = new Point(2, 3, '*');

            //p1.Draw();

            Figure[] figures = new Figure[2];
            figures[0] = new Square(2, 5, '*');
            figures[1] = new Stick(6, 6, '*');

            foreach(var figure in figures)
            {
                figure.Draw();
            }
        }
    }
}
