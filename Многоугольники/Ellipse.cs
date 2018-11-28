using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Многоугольники
{
    public class Ellipse : Shape
    {

        public Ellipse(int x, int y) : base(x, y)
        {
        }

        public override void FlagUpdater(int x1, int y1) //проверка попадания курсора в фигуру
        {
            if (Math.Sqrt(Math.Abs(x1 - X)* Math.Abs(x1 - X) + Math.Abs(y1 - Y)*Math.Abs(y1 - Y)) <= R) //вычисление расстояния от центра до точки по теореме Пифагора. Расстояние меньше или равно радиусу - точка подходит.
            { FLAG = true; }
            else
            {
                FLAG = false;
            }
        }

        public override void Draw(Graphics x) //отрисовка
        {
            brush = new SolidBrush(Filler);
            x.FillEllipse(brush, (int)(X - R), (int)(Y - R), 2 * R, 2 * R);
        }
       
    }
}
