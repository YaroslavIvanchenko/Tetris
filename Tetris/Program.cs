using System;
using System.Threading;

namespace Tetris
{
    internal class Program
    {
        static void Main(string[] args)
        {
#pragma warning disable CA1416 // Validate platform compatibility
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);
#pragma warning restore CA1416 // Validate platform compatibility


            var generator = new FigureGenerator(20, 0, '*');
            Figure s = null;

            while(true)
            {
                FigureFall(s, generator);
            }
           
        }

        static void FigureFall(Figure figure, FigureGenerator figureGenerator)
        {
            figure = figureGenerator.GetNewFigure();
            figure.Draw();

            for(int i = 0; i < 10; i++)
            {
                figure.Hide();
                figure.Move(Direction.DOWN);
                figure.Draw();
                Thread.Sleep(200);
            }

        }
    }
}
