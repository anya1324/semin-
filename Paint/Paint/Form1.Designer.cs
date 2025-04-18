namespace Paint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            layerPanel = new Panel();
            layer_text = new TextBox();
            next_layer_btn = new Button();
            prev_layer_btn = new Button();
            eraser_btn = new Button();
            pictureBox_rgb = new PictureBox();
            rec_btn = new Button();
            color_btn = new Button();
            saveFileDialog1 = new SaveFileDialog();
            save_btn = new Button();
            clear_btn = new Button();
            label1 = new Label();
            el_btn = new Button();
            fill = new CheckBox();
            thicknes_text = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            layerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_rgb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)thicknes_text).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Cursor = Cursors.Cross;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += Update;
            pictureBox1.MouseDown += PictureBox1_mouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += PictureBox1_MouseUp;
            // 
            // layerPanel
            // 
            layerPanel.Controls.Add(layer_text);
            layerPanel.Controls.Add(next_layer_btn);
            layerPanel.Controls.Add(prev_layer_btn);
            layerPanel.Location = new Point(0, 0);
            layerPanel.Name = "layerPanel";
            layerPanel.Size = new Size(133, 29);
            layerPanel.TabIndex = 2;
            // 
            // layer_text
            // 
            layer_text.Location = new Point(39, 4);
            layer_text.Name = "layer_text";
            layer_text.Size = new Size(57, 23);
            layer_text.TabIndex = 3;
            layer_text.TextChanged += layer_text_TextChanged;
            // 
            // next_layer_btn
            // 
            next_layer_btn.Location = new Point(102, 3);
            next_layer_btn.Name = "next_layer_btn";
            next_layer_btn.Size = new Size(28, 23);
            next_layer_btn.TabIndex = 2;
            next_layer_btn.Text = ">";
            next_layer_btn.UseVisualStyleBackColor = true;
            next_layer_btn.Click += next_layer_btn_Click;
            // 
            // prev_layer_btn
            // 
            prev_layer_btn.Location = new Point(4, 3);
            prev_layer_btn.Name = "prev_layer_btn";
            prev_layer_btn.Size = new Size(29, 23);
            prev_layer_btn.TabIndex = 1;
            prev_layer_btn.Text = "<";
            prev_layer_btn.UseVisualStyleBackColor = true;
            prev_layer_btn.Click += prev_layer_btn_Click;
            // 
            // eraser_btn
            // 
            eraser_btn.Location = new Point(139, 3);
            eraser_btn.Name = "eraser_btn";
            eraser_btn.Size = new Size(75, 23);
            eraser_btn.TabIndex = 3;
            eraser_btn.Text = "eraser";
            eraser_btn.UseVisualStyleBackColor = true;
            eraser_btn.Click += eraser_btn_Click;
            // 
            // pictureBox_rgb
            // 
            pictureBox_rgb.Image = (Image)resources.GetObject("pictureBox_rgb.Image");
            pictureBox_rgb.Location = new Point(326, 4);
            pictureBox_rgb.Name = "pictureBox_rgb";
            pictureBox_rgb.Size = new Size(390, 259);
            pictureBox_rgb.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox_rgb.TabIndex = 5;
            pictureBox_rgb.TabStop = false;
            pictureBox_rgb.Click += pictureBox_rgb_Click;
            pictureBox_rgb.MouseMove += pictureBox_rgb_MouseMove;
            // 
            // rec_btn
            // 
            rec_btn.Location = new Point(407, 7);
            rec_btn.Name = "rec_btn";
            rec_btn.Size = new Size(75, 23);
            rec_btn.TabIndex = 6;
            rec_btn.Text = "rectangle";
            rec_btn.UseVisualStyleBackColor = true;
            rec_btn.Click += rec_btn_Click;
            // 
            // color_btn
            // 
            color_btn.Location = new Point(326, 6);
            color_btn.Name = "color_btn";
            color_btn.Size = new Size(75, 23);
            color_btn.TabIndex = 7;
            color_btn.Text = "color";
            color_btn.UseVisualStyleBackColor = true;
            color_btn.Click += color_btn_Click;
            // 
            // save_btn
            // 
            save_btn.Location = new Point(725, 0);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(75, 23);
            save_btn.TabIndex = 8;
            save_btn.Text = "save";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // clear_btn
            // 
            clear_btn.Location = new Point(139, 32);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(75, 23);
            clear_btn.TabIndex = 10;
            clear_btn.Text = "clear layer";
            clear_btn.UseVisualStyleBackColor = true;
            clear_btn.Click += clear_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(220, 7);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 11;
            label1.Text = "thickness:";
            // 
            // el_btn
            // 
            el_btn.Location = new Point(488, 7);
            el_btn.Name = "el_btn";
            el_btn.Size = new Size(75, 23);
            el_btn.TabIndex = 12;
            el_btn.Text = "ellipse";
            el_btn.UseVisualStyleBackColor = true;
            el_btn.Click += el_btn_Click_1;
            // 
            // fill
            // 
            fill.AutoSize = true;
            fill.Location = new Point(569, 12);
            fill.Name = "fill";
            fill.Size = new Size(39, 19);
            fill.TabIndex = 13;
            fill.Text = "fill";
            fill.UseVisualStyleBackColor = true;
            // 
            // thicknes_text
            // 
            thicknes_text.Location = new Point(276, 7);
            thicknes_text.Name = "thicknes_text";
            thicknes_text.Size = new Size(44, 23);
            thicknes_text.TabIndex = 14;
            thicknes_text.ValueChanged += thicknes_text_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(thicknes_text);
            Controls.Add(fill);
            Controls.Add(el_btn);
            Controls.Add(label1);
            Controls.Add(clear_btn);
            Controls.Add(save_btn);
            Controls.Add(color_btn);
            Controls.Add(rec_btn);
            Controls.Add(pictureBox_rgb);
            Controls.Add(eraser_btn);
            Controls.Add(layerPanel);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Paint Beta";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            layerPanel.ResumeLayout(false);
            layerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_rgb).EndInit();
            ((System.ComponentModel.ISupportInitialize)thicknes_text).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel layerPanel;
        private Button next_layer_btn;
        private Button prev_layer_btn;
        private Button eraser_btn;
        private PictureBox pictureBox_rgb;
        private Button rec_btn;
        private Button color_btn;
        private SaveFileDialog saveFileDialog1;
        private Button save_btn;
        private Button clear_btn;
        private Label label1;
        private Button el_btn;
        private CheckBox fill;
        private NumericUpDown thicknes_text;
        private TextBox layer_text;
    }
}
