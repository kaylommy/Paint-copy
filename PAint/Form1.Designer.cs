namespace PAint
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
            panel1 = new Panel();
            btn_save = new Button();
            btn_clear = new Button();
            color_picker = new PictureBox();
            btn_rect = new Button();
            btn_ellipse = new Button();
            btn_eraser = new Button();
            btn_pencil = new Button();
            btn_fill = new Button();
            pic_color = new Button();
            panel3 = new Panel();
            btn_color = new Button();
            btn_line = new Button();
            panel2 = new Panel();
            pic = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)color_picker).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 209, 220);
            panel1.Controls.Add(btn_save);
            panel1.Controls.Add(btn_clear);
            panel1.Controls.Add(color_picker);
            panel1.Controls.Add(btn_rect);
            panel1.Controls.Add(btn_ellipse);
            panel1.Controls.Add(btn_eraser);
            panel1.Controls.Add(btn_pencil);
            panel1.Controls.Add(btn_fill);
            panel1.Controls.Add(pic_color);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 107);
            panel1.TabIndex = 0;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(200, 150, 170);
            btn_save.Cursor = Cursors.Hand;
            btn_save.FlatAppearance.MouseDownBackColor = Color.FromArgb(245, 195, 194);
            btn_save.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.ForeColor = Color.White;
            btn_save.ImageAlign = ContentAlignment.TopCenter;
            btn_save.Location = new Point(802, 12);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(73, 34);
            btn_save.TabIndex = 11;
            btn_save.Text = "save";
            btn_save.UseVisualStyleBackColor = false;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.FromArgb(200, 150, 170);
            btn_clear.Cursor = Cursors.Hand;
            btn_clear.FlatAppearance.MouseDownBackColor = Color.FromArgb(245, 195, 194);
            btn_clear.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.ForeColor = Color.White;
            btn_clear.ImageAlign = ContentAlignment.TopCenter;
            btn_clear.Location = new Point(802, 52);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(73, 37);
            btn_clear.TabIndex = 10;
            btn_clear.Text = "clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += button1_Click;
            // 
            // color_picker
            // 
            color_picker.Cursor = Cursors.Hand;
            color_picker.Image = Properties.Resources.color_palette;
            color_picker.Location = new Point(3, 0);
            color_picker.Name = "color_picker";
            color_picker.Size = new Size(170, 104);
            color_picker.SizeMode = PictureBoxSizeMode.StretchImage;
            color_picker.TabIndex = 0;
            color_picker.TabStop = false;
            color_picker.Click += color_picker_Click;
            color_picker.MouseClick += color_picker_MouseClick;
            // 
            // btn_rect
            // 
            btn_rect.BackColor = Color.FromArgb(200, 150, 170);
            btn_rect.Cursor = Cursors.Hand;
            btn_rect.FlatAppearance.MouseDownBackColor = Color.FromArgb(245, 195, 194);
            btn_rect.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btn_rect.FlatStyle = FlatStyle.Flat;
            btn_rect.ForeColor = Color.White;
            btn_rect.Image = Properties.Resources.rectangle;
            btn_rect.ImageAlign = ContentAlignment.TopCenter;
            btn_rect.Location = new Point(638, 18);
            btn_rect.Name = "btn_rect";
            btn_rect.Size = new Size(73, 63);
            btn_rect.TabIndex = 8;
            btn_rect.Text = "rectangle";
            btn_rect.TextAlign = ContentAlignment.BottomCenter;
            btn_rect.UseVisualStyleBackColor = false;
            btn_rect.Click += btn_rect_Click;
            // 
            // btn_ellipse
            // 
            btn_ellipse.BackColor = Color.FromArgb(200, 150, 170);
            btn_ellipse.Cursor = Cursors.Hand;
            btn_ellipse.FlatAppearance.MouseDownBackColor = Color.FromArgb(245, 195, 194);
            btn_ellipse.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btn_ellipse.FlatStyle = FlatStyle.Flat;
            btn_ellipse.ForeColor = Color.White;
            btn_ellipse.Image = Properties.Resources.circle;
            btn_ellipse.ImageAlign = ContentAlignment.TopCenter;
            btn_ellipse.Location = new Point(559, 18);
            btn_ellipse.Name = "btn_ellipse";
            btn_ellipse.Size = new Size(73, 63);
            btn_ellipse.TabIndex = 7;
            btn_ellipse.Text = "circle";
            btn_ellipse.TextAlign = ContentAlignment.BottomCenter;
            btn_ellipse.UseVisualStyleBackColor = false;
            btn_ellipse.Click += btn_ellipse_Click;
            // 
            // btn_eraser
            // 
            btn_eraser.BackColor = Color.FromArgb(200, 150, 170);
            btn_eraser.Cursor = Cursors.Hand;
            btn_eraser.FlatAppearance.MouseDownBackColor = Color.FromArgb(245, 195, 194);
            btn_eraser.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btn_eraser.FlatStyle = FlatStyle.Flat;
            btn_eraser.ForeColor = Color.White;
            btn_eraser.Image = Properties.Resources.eraser;
            btn_eraser.ImageAlign = ContentAlignment.MiddleLeft;
            btn_eraser.Location = new Point(480, 18);
            btn_eraser.Name = "btn_eraser";
            btn_eraser.Size = new Size(73, 63);
            btn_eraser.TabIndex = 6;
            btn_eraser.Text = "eraser";
            btn_eraser.TextAlign = ContentAlignment.BottomCenter;
            btn_eraser.UseVisualStyleBackColor = false;
            btn_eraser.Click += btn_eraser_Click;
            // 
            // btn_pencil
            // 
            btn_pencil.BackColor = Color.FromArgb(200, 150, 170);
            btn_pencil.Cursor = Cursors.Hand;
            btn_pencil.FlatAppearance.MouseDownBackColor = Color.FromArgb(245, 195, 194);
            btn_pencil.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btn_pencil.FlatStyle = FlatStyle.Flat;
            btn_pencil.ForeColor = Color.White;
            btn_pencil.Image = Properties.Resources.pencil;
            btn_pencil.ImageAlign = ContentAlignment.MiddleLeft;
            btn_pencil.Location = new Point(401, 18);
            btn_pencil.Name = "btn_pencil";
            btn_pencil.Size = new Size(73, 63);
            btn_pencil.TabIndex = 5;
            btn_pencil.Text = "pencil";
            btn_pencil.TextAlign = ContentAlignment.BottomCenter;
            btn_pencil.UseVisualStyleBackColor = false;
            btn_pencil.Click += btn_pencil_Click;
            // 
            // btn_fill
            // 
            btn_fill.BackColor = Color.FromArgb(200, 150, 170);
            btn_fill.Cursor = Cursors.Hand;
            btn_fill.FlatAppearance.MouseDownBackColor = Color.FromArgb(245, 195, 194);
            btn_fill.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btn_fill.FlatStyle = FlatStyle.Flat;
            btn_fill.ForeColor = Color.White;
            btn_fill.Image = Properties.Resources.bucket;
            btn_fill.ImageAlign = ContentAlignment.MiddleLeft;
            btn_fill.Location = new Point(322, 18);
            btn_fill.Name = "btn_fill";
            btn_fill.Size = new Size(73, 63);
            btn_fill.TabIndex = 4;
            btn_fill.Text = "fill";
            btn_fill.TextAlign = ContentAlignment.BottomCenter;
            btn_fill.UseVisualStyleBackColor = false;
            // 
            // pic_color
            // 
            pic_color.BackColor = Color.White;
            pic_color.Location = new Point(179, 35);
            pic_color.Name = "pic_color";
            pic_color.Size = new Size(48, 35);
            pic_color.TabIndex = 2;
            pic_color.UseVisualStyleBackColor = false;
            pic_color.Click += pic_color_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 192, 192);
            panel3.Controls.Add(btn_color);
            panel3.Controls.Add(btn_line);
            panel3.Location = new Point(233, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(564, 77);
            panel3.TabIndex = 2;
            // 
            // btn_color
            // 
            btn_color.BackColor = Color.FromArgb(200, 150, 170);
            btn_color.Cursor = Cursors.Hand;
            btn_color.FlatAppearance.MouseDownBackColor = Color.FromArgb(245, 195, 194);
            btn_color.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btn_color.FlatStyle = FlatStyle.Flat;
            btn_color.ForeColor = Color.White;
            btn_color.Image = Properties.Resources.color;
            btn_color.ImageAlign = ContentAlignment.MiddleLeft;
            btn_color.Location = new Point(10, 6);
            btn_color.Name = "btn_color";
            btn_color.Size = new Size(73, 63);
            btn_color.TabIndex = 3;
            btn_color.Text = "color";
            btn_color.TextAlign = ContentAlignment.BottomCenter;
            btn_color.UseVisualStyleBackColor = false;
            btn_color.Click += btn_color_Click;
            // 
            // btn_line
            // 
            btn_line.BackColor = Color.FromArgb(200, 150, 170);
            btn_line.Cursor = Cursors.Hand;
            btn_line.FlatAppearance.MouseDownBackColor = Color.FromArgb(245, 195, 194);
            btn_line.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btn_line.FlatStyle = FlatStyle.Flat;
            btn_line.ForeColor = Color.White;
            btn_line.Image = Properties.Resources.line;
            btn_line.ImageAlign = ContentAlignment.TopCenter;
            btn_line.Location = new Point(484, 6);
            btn_line.Name = "btn_line";
            btn_line.Size = new Size(73, 63);
            btn_line.TabIndex = 9;
            btn_line.Text = "line";
            btn_line.TextAlign = ContentAlignment.BottomCenter;
            btn_line.UseVisualStyleBackColor = false;
            btn_line.Click += btn_line_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 209, 220);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 482);
            panel2.Name = "panel2";
            panel2.Size = new Size(887, 29);
            panel2.TabIndex = 1;
            // 
            // pic
            // 
            pic.BackColor = Color.White;
            pic.Dock = DockStyle.Fill;
            pic.Location = new Point(0, 0);
            pic.Name = "pic";
            pic.Size = new Size(887, 511);
            pic.TabIndex = 0;
            pic.TabStop = false;
            pic.Click += pictureBox1_Click;
            pic.Paint += pic_Paint;
            pic.MouseDown += pic_MouseDown;
            pic.MouseMove += pic_MouseMove;
            pic.MouseUp += pic_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 511);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pic);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)color_picker).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pic;
        private Button pic_color;
        private Button btn_color;
        private Button btn_line;
        private Button btn_rect;
        private Button btn_ellipse;
        private Button btn_eraser;
        private Button btn_pencil;
        private Button btn_fill;
        private Panel panel3;
        private PictureBox color_picker;
        private Button btn_clear;
        private Button btn_save;
    }
}
