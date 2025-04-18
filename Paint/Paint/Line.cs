using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    public class Line : Shape
    {
        public Line(Point p1, Point p2, Pen pen) : base(pen) 
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public override void Draw(Graphics g)
        {
            g.DrawLine(pen, p1, p2);
        }
    }
}
