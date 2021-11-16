namespace Tetris
{
    public class Figure
    {
        public Point[] points = new Point[4];

        public void Draw()
        {
            foreach (Point p in points)
            {
                p.Draw();
            }
        }
    }
}
