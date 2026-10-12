using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShapesInheritanceExample
{
    public class Circle:Shape
    {
        protected int radius;
       
        protected int x, y; //note I could use c# properties for this
        public Circle(Color colour, int x, int y, int radius): base(colour, x, y)
        {


            this.radius = radius;
        }

        public override void draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            SolidBrush b = new SolidBrush(colour);
            g.FillEllipse(b, x, y, radius * 2, radius * 2);
            g.DrawEllipse(p, x, y, radius * 2, radius * 2);
            base.draw(g);
        }

      

    }
}