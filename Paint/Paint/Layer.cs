namespace Paint
{
    public class Layer
    {
        public string name;
        public List<Shape> layer = new List<Shape>();

        public Layer() 
        {
            name = Form1.layer.Count.ToString();
            if (Form1.layer.Count == 0)
                name = "all";
        }

        public void DrawShape(State state, Pen pen, Point p1, Point p2, bool fill)
        {
            if (state == State.rectangle)
            {
                layer.Add(new Rectangle(pen, p1, p2, fill));
            }
            if (state == State.ellipse)
            {
                layer.Add(new Elipse(pen, p1, p2, fill));
            }
        }

        public void Erase(MouseEventArgs e)
        {
            for (int i = 0; i < layer.Count; i++)
            {
                if (Math.Abs(layer[i].p1.X - e.X) < Form1.thickness && Math.Abs(layer[i].p1.Y - e.Y) < Form1.thickness)
                    layer.Remove(layer[i]);
            }
        }
    }
}