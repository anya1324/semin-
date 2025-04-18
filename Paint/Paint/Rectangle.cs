namespace Paint
{
    public class Rectangle : Shape
    {
        public Rectangle(Pen pen, Point p1, Point p2, bool fill) : base(pen)
        {
            this.p1 = new Point((int)Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y));
            width = Math.Abs(p2.X - p1.X);
            height = Math.Abs(p2.Y - p1.Y);
            this.fill = fill;
        }

        public override void Draw(Graphics g)
        {
            if (fill) g.FillRectangle(new SolidBrush(pen.Color), p1.X, p1.Y, width, height);
            else g.DrawRectangle(pen, p1.X, p1.Y, width, height);
        }
    }
}
