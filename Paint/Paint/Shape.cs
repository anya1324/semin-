namespace Paint
{
    public class Shape
    {
        public Point p1;
        public Point p2;
        public int width;
        public int height;
        public bool fill;

        public Pen pen;

        public Shape(Pen pen) => this.pen = pen;

        public virtual void Draw(Graphics g) { }
    }
}