using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroidaCalc
{
    public struct doublePoint
    {
        public double x;
        public double y;

        public doublePoint(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public static class Astroida
    {
        public static List<doublePoint> CalcGraph(int accuracy, double radius)
        {
            List<doublePoint> points = new List<doublePoint>();

            double step = 2 * Math.PI / accuracy;
            double x_value = 0;
            double y_value = 0;
            double t_value = 0;

            while (t_value < 2 * Math.PI)
            {
                x_value = radius * Math.Pow(Math.Cos(t_value), 3);
                y_value = radius * Math.Pow(Math.Sin(t_value), 3);

                points.Add(new doublePoint(x_value, y_value));

                t_value += step;
            }

            return points;
        }
    }
}
