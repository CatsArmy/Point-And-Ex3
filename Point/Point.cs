using System;

namespace point
{
    public class Point
    {
        public double X;
        public double Y;
        public Point()
        {
            this.X = 0.0;
            this.Y = 0.0;
        }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        public double GetXPoint()
        {
            return this.X;
        }
        public double GetYPoint()
        {
            return this.Y;
        }
        public void SetX(double x)
        {
            this.X = x;
        }
        public void SetY(double y)
        {
            this.Y = y;
        }
        public Point Mid(Point other)
        {
            Point M = new Point();
            M.SetX((this.X + other.GetXPoint()) / 2);
            M.SetY((this.Y + other.GetYPoint()) / 2);
            return M;
        }
        public double Distance(Point other)
        {
            double dX2 = Math.Pow((this.X - other.X), 2);
            double dY2 = Math.Pow((this.Y - other.Y), 2);
            return (Math.Sqrt(dX2 + dY2));
        }
        public string Description()
        {
            return $"x= {this.X} y={this.Y} ";
        }
    }
}