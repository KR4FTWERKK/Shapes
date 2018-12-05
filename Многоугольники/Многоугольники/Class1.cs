using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Многоугольники
{
    public abstract class Shape
    {
        protected static int R; //радиус
        public abstract void Draw(); 
        protected int x;
        protected int y;
    }
    public class Circle: Shape
    {
        public override void Draw()
        {
          
        }

    } 
    public class Rectangle : Shape
    {
        public override void Draw()
        {
        
        }
    }
    public class Triangle : Shape
    {
        public override void Draw()
        {
            
        }
    }
}
