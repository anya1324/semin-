namespace Paint
{
    public partial class Form1 : Form
    {
        public static Memory memory;
        public static List<Layer> layer = new List<Layer>();
        private Point last;

        public static int thickness = 2;

        private State state;
        public static Pen pen;
        private string savePath;
        private int lastID;
        public static (int start, int end) current;

        Point? lastpos;

        public Form1()
        {
            InitializeComponent();

            layer.Add(new Layer());

            memory = new Memory();
            pictureBox_rgb.Visible = false;
            state = State.paint;
            thicknes_text.Text = thickness.ToString();
            savePath = "";
            current = (0, 1);

            Bitmap bm = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            pictureBox1.Image = bm;
            pen = new Pen(Color.Black);

            Controls.Add(pictureBox1);
        }

        private void Update(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = current.start; i < current.end; i++)
            {
                DrawFrame(i, g);
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || state == State.rectangle || state == State.ellipse) return;

            else if (state == State.paint) Draw(e);
            else if (state == State.erase) Erase(e);

            lastpos = new Point(e.X, e.Y);
            Refresh();
        }

        private void PictureBox1_mouseDown(object sender, MouseEventArgs e)
        {
            lastID = GetLayer().layer.Count;
            if (state == State.rectangle || state == State.ellipse)
                last = new Point(e.X, e.Y);
        }
        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            memory.AddAction(lastID);
            layer[current.start].DrawShape(state, new Pen(pen.Color, thickness),
                    new Point(e.X, last.Y), new Point(last.X, e.Y), fill.Checked);

            lastpos = null;

            Refresh();
        }
        private void pictureBox_rgb_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixel = (Bitmap)pictureBox_rgb.Image;
            pen.Color = pixel.GetPixel(e.X, e.Y);
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            for (int i = current.start; i < current.end; i++)
            {
                layer[i].layer.Clear();
            }
            Refresh();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.ShowDialog();
                savePath = saveFileDialog1.FileName;
                Bitmap img = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                pictureBox1.DrawToBitmap(img, new System.Drawing.Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
                img.Save(savePath);
            }
            catch { }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Z))
            {
                memory.Undo();
                Refresh();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #region clean methods
        private void DrawFrame(int index, Graphics g)
        {
            foreach (var v in layer[index].layer)
            {
                v.Draw(g);
            }
        }
        private void Erase(MouseEventArgs e)
        {
            for (int i = current.start; i < current.end; i++)
                layer[i].Erase(e);
        }
        private void Draw(MouseEventArgs e)
        {
            layer[current.start].layer.Add(new Line(e.Location, lastpos == null ? e.Location : (Point)lastpos, new Pen(pen.Color, thickness)));
        }
        #endregion
        #region layers
        private void prev_layer_btn_Click(object sender, EventArgs e)
        {
            if (current.start != 0) ChangeLayer(current.start - 1);
            else current.end = layer.Count;
        }
        private void next_layer_btn_Click(object sender, EventArgs e)
        {
            if (current.start + 1 == layer.Count)
                layer.Add(new Layer());
            ChangeLayer(current.start + 1);
        }
        private void ChangeLayer(int index)
        {
            current = (index, index+1);
            layer_text.Text = layer[current.start].name;
            Refresh();
        }
        #endregion
        #region short methods
        public void pictureBox_rgb_Click(object sender, EventArgs e)
        {
            color_btn.BackColor = pen.Color;
            pictureBox_rgb.Visible = false;
        }
        private void color_btn_Click(object sender, EventArgs e)
        {
            pictureBox_rgb.Visible = true;
            memory.AddAction(pen.Color);
        }
        private void eraser_btn_Click(object sender, EventArgs e)
            => state = state == State.erase ? State.paint : State.erase;
        private void rec_btn_Click(object sender, EventArgs e)
            => state = state == State.rectangle ? State.paint : State.rectangle;
        private void el_btn_Click_1(object sender, EventArgs e)
            => state = state == State.ellipse ? State.paint : State.ellipse;
        private void thicknes_text_ValueChanged(object sender, EventArgs e)
            => thickness = int.Parse(thicknes_text.Text);
        private void layer_text_TextChanged(object sender, EventArgs e)
            => layer[current.start].name = layer_text.Text;
        public static Layer GetLayer()
            => layer[current.start];
        #endregion
    }
}