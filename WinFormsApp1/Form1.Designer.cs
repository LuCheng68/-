namespace WinFormsApp1
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
            uiPanel1 = new Sunny.UI.UIPanel();
            uiHeaderButton5 = new Sunny.UI.UIHeaderButton();
            uiHeaderButton4 = new Sunny.UI.UIHeaderButton();
            uiHeaderButton3 = new Sunny.UI.UIHeaderButton();
            uiHeaderButton2 = new Sunny.UI.UIHeaderButton();
            uiHeaderButton1 = new Sunny.UI.UIHeaderButton();
            pictureBox1 = new PictureBox();
            uiPanel2 = new Sunny.UI.UIPanel();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(uiHeaderButton5);
            uiPanel1.Controls.Add(uiHeaderButton4);
            uiPanel1.Controls.Add(uiHeaderButton3);
            uiPanel1.Controls.Add(uiHeaderButton2);
            uiPanel1.Controls.Add(uiHeaderButton1);
            uiPanel1.Controls.Add(pictureBox1);
            uiPanel1.Dock = DockStyle.Top;
            uiPanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPanel1.Location = new Point(0, 0);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new Size(1258, 127);
            uiPanel1.TabIndex = 0;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiHeaderButton5
            // 
            uiHeaderButton5.FillColor = Color.FromArgb(243, 249, 255);
            uiHeaderButton5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiHeaderButton5.ForeColor = Color.Black;
            uiHeaderButton5.Image = Properties.Resources.用户;
            uiHeaderButton5.Location = new Point(1007, 23);
            uiHeaderButton5.MinimumSize = new Size(1, 1);
            uiHeaderButton5.Name = "uiHeaderButton5";
            uiHeaderButton5.Padding = new Padding(0, 8, 0, 3);
            uiHeaderButton5.Radius = 0;
            uiHeaderButton5.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            uiHeaderButton5.RectSides = ToolStripStatusLabelBorderSides.None;
            uiHeaderButton5.Size = new Size(108, 101);
            uiHeaderButton5.TabIndex = 1;
            uiHeaderButton5.Text = "用户管理";
            uiHeaderButton5.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // uiHeaderButton4
            // 
            uiHeaderButton4.FillColor = Color.FromArgb(243, 249, 255);
            uiHeaderButton4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiHeaderButton4.ForeColor = Color.Black;
            uiHeaderButton4.Image = Properties.Resources.统计图阳;
            uiHeaderButton4.Location = new Point(836, 23);
            uiHeaderButton4.MinimumSize = new Size(1, 1);
            uiHeaderButton4.Name = "uiHeaderButton4";
            uiHeaderButton4.Padding = new Padding(0, 8, 0, 3);
            uiHeaderButton4.Radius = 0;
            uiHeaderButton4.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            uiHeaderButton4.RectSides = ToolStripStatusLabelBorderSides.None;
            uiHeaderButton4.Size = new Size(108, 101);
            uiHeaderButton4.TabIndex = 1;
            uiHeaderButton4.Text = "产量管理";
            uiHeaderButton4.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiHeaderButton4.Click += uiHeaderButton4_Click;
            // 
            // uiHeaderButton3
            // 
            uiHeaderButton3.FillColor = Color.FromArgb(243, 249, 255);
            uiHeaderButton3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiHeaderButton3.ForeColor = Color.Black;
            uiHeaderButton3.Image = Properties.Resources.照相机;
            uiHeaderButton3.Location = new Point(662, 23);
            uiHeaderButton3.MinimumSize = new Size(1, 1);
            uiHeaderButton3.Name = "uiHeaderButton3";
            uiHeaderButton3.Padding = new Padding(0, 8, 0, 3);
            uiHeaderButton3.Radius = 0;
            uiHeaderButton3.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            uiHeaderButton3.RectSides = ToolStripStatusLabelBorderSides.None;
            uiHeaderButton3.Size = new Size(108, 101);
            uiHeaderButton3.TabIndex = 1;
            uiHeaderButton3.Text = "相机管理";
            uiHeaderButton3.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // uiHeaderButton2
            // 
            uiHeaderButton2.FillColor = Color.FromArgb(243, 249, 255);
            uiHeaderButton2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiHeaderButton2.ForeColor = Color.Black;
            uiHeaderButton2.Image = Properties.Resources.IO_01__1_;
            uiHeaderButton2.Location = new Point(480, 23);
            uiHeaderButton2.MinimumSize = new Size(1, 1);
            uiHeaderButton2.Name = "uiHeaderButton2";
            uiHeaderButton2.Padding = new Padding(0, 8, 0, 3);
            uiHeaderButton2.Radius = 0;
            uiHeaderButton2.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            uiHeaderButton2.RectSides = ToolStripStatusLabelBorderSides.None;
            uiHeaderButton2.Size = new Size(108, 101);
            uiHeaderButton2.TabIndex = 1;
            uiHeaderButton2.Text = "IO管理";
            uiHeaderButton2.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // uiHeaderButton1
            // 
            uiHeaderButton1.FillColor = Color.FromArgb(243, 249, 255);
            uiHeaderButton1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiHeaderButton1.ForeColor = Color.Black;
            uiHeaderButton1.Image = Properties.Resources.日志01__1_;
            uiHeaderButton1.Location = new Point(300, 23);
            uiHeaderButton1.MinimumSize = new Size(1, 1);
            uiHeaderButton1.Name = "uiHeaderButton1";
            uiHeaderButton1.Padding = new Padding(0, 8, 0, 3);
            uiHeaderButton1.Radius = 3;
            uiHeaderButton1.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            uiHeaderButton1.RectSides = ToolStripStatusLabelBorderSides.None;
            uiHeaderButton1.Size = new Size(108, 101);
            uiHeaderButton1.TabIndex = 1;
            uiHeaderButton1.Text = "操作日志";
            uiHeaderButton1.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.公司logo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // uiPanel2
            // 
            uiPanel2.Dock = DockStyle.Fill;
            uiPanel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPanel2.Location = new Point(0, 127);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Size = new Size(1258, 617);
            uiPanel2.TabIndex = 1;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 744);
            Controls.Add(uiPanel2);
            Controls.Add(uiPanel1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private PictureBox pictureBox1;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIHeaderButton uiHeaderButton5;
        private Sunny.UI.UIHeaderButton uiHeaderButton4;
        private Sunny.UI.UIHeaderButton uiHeaderButton3;
        private Sunny.UI.UIHeaderButton uiHeaderButton2;
        private Sunny.UI.UIHeaderButton uiHeaderButton1;
    }
}
