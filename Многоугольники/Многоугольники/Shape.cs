using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Многоугольники
{
    public abstract class Shape
    {
        protected bool Flag = false;
        protected bool Deletement_Flag = false;
        protected SolidBrush brush;
        protected static Color Outline;
        protected static Color Filler;
        protected static int r; //радиус
        public abstract void Draw(Graphics x);
        public abstract void FlagUpdater(int x1, int x2);
        protected int x;
        protected int y;
        public bool FLAG
        {
            get
            {
                return Flag;
            }
            set
            {
                Flag = value;
            }
        } //Флаг на Drag/Drop
        public bool DO_NOT_DELETE_FLAG
        {
            get
            {
                return Deletement_Flag;
            }
            set
            {
                Deletement_Flag = value;
            }
        } //Флаг на удаление после Drag/Drop
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public static Color FillColor
        {
            get
            {
                return Filler;
            }
            set
            {
                Filler = value;
            }
        }
        public static Color OutlineColor
        {
            get
            {
                return Outline;
            }
            set
            {
                Outline = value;
            }
        }
        public int R
        {
            get
            {
                return r;
            }
            set
            {
                r = value;
            }
        }
        static Shape()//статический конструктор
        {
            Outline = Color.Blue;
            r = 20;
            Filler = Color.Red;
        }
        public Shape(int x, int y)//динамический конструктор
        {
            this.x = x;
            this.y = y;
        }
    }
}