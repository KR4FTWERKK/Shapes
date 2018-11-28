using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Многоугольники
{
    class Rectangle : Shape
    {
        public override void FlagUpdater(int x1, int y1) //проверка попадания курсора в фигуру
        {
            if (Math.Abs(x1 - X) <= R / Math.Sqrt(2) & Math.Abs(y1 - Y) <= R / Math.Sqrt(2)) //макс расстояние по х и у не должно привышать R/корень из 2 от центра, т.к длина стороны - 2*R/корень из 2.
            { FLAG = true; }
            else
            {
                FLAG = false;
            }
        }
        public Rectangle(int x, int y) : base(x, y)
        {

        }
        public override void Draw(Graphics x) //отрисовка
        {
            brush = new SolidBrush(Filler);
            x.FillRectangle(brush, (int)(X - R / Math.Sqrt(2)), (int)(Y - R / Math.Sqrt(2)), (int)(2 * R / Math.Sqrt(2)), (int)(2 * R / Math.Sqrt(2)));
        } 
    }
}
