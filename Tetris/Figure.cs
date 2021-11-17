using System;

namespace Tetris
{
    public abstract class Figure
    {
        public Point[] points = new Point[4];

        public void Draw()
        {
            foreach (Point p in points)
            {
                p.Draw();
            }
        }

        public void Move(Direction direction)
        {
            foreach(Point p in points)
            {
                p.Move(direction);
            }
        }
        public void Hide()
        {
            foreach(var p in points)
            {
                p.Hide();
            }
        }

        public abstract void Rotate();
        
    }
}
