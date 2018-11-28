using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Многоугольники
{
    public class Triangle : Shape
    {
        private Point[] Trigon;
        public override void FlagUpdater(int x1, int y1) //проверка попадания курсора в фигуру
        {
            if (y1 - (Y - R) <= 1.5 * R & Math.Abs(x1 - x) <= ((y1 - (Y - R)) * 0.57)) //((y1 - (Y - R)) * Math.Sqrt(3) / 2) -  рассчёт x в зависимости от расстояния от центральной вершины до y проверяемой точки,  Math.Abs(x1-x) - расстояние от центральной оси треугольника через x точки и x оси. 
            { FLAG = true; }
            else
            {
                FLAG = false;
            }
        }
        public Triangle(int x, int y) : base(x, y)
        {

        }
        public override void Draw(Graphics x) //отрисовка
        {
            brush = new SolidBrush(Filler);
            Trigon = new Point[] { new Point((int)(X - R * 0.86), (int)(Y + R * 0.5)), new Point(X, Y - R), new Point((int)(X + R * 0.86), (int)(Y + R * 0.5)) };
            x.FillPolygon(brush, Trigon);

        }
    }
}

