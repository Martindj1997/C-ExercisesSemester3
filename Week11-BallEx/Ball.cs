using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_BallEx
{
    /// <summary>
    /// This class encapsulates the physical attributes of a 2D Ball, a method to draw the Ball
    /// and a way to calculate whether or not a point is inside the Ball
    /// </summary>
    class Ball
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Radius { get; private set; }
        public Color BallColour { get; private set; }
        public Ball(int x1, int y1, int radius, Color color)
        {
            X = x1;
            Y = y1;
            Radius = radius;
            BallColour = color;
        }
        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(BallColour);
            g.FillEllipse(b, X, Y, Radius * 2, Radius * 2);
        }
        public Boolean PointInBall(int x, int y)
        {
            double cx = X + Radius;
            double cy = Y + Radius;
            double distance = Math.Sqrt(Math.Pow((cx - x), 2) + Math.Pow((cy - y), 2));
            return distance <= Radius;
        }
    }
    }
