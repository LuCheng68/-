namespace WinFormsApp1
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            uiGroupBox4 = new Sunny.UI.UIGroupBox();
            uiDataGridView1 = new Sunny.UI.UIDataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            uiGroupBox2 = new Sunny.UI.UIGroupBox();
            uiTextBox4 = new Sunny.UI.UITextBox();
            uiTextBox3 = new Sunny.UI.UITextBox();
            uiLabel2 = new Sunny.UI.UILabel();
            uiAvatar1 = new Sunny.UI.UIAvatar();
            uiLabel1 = new Sunny.UI.UILabel();
            uiGroupBox3 = new Sunny.UI.UIGroupBox();
            uiButton4 = new Sunny.UI.UIButton();
            uiButton3 = new Sunny.UI.UIButton();
            uiButton2 = new Sunny.UI.UIButton();
            uiButton1 = new Sunny.UI.UIButton();
            uiTextBox1 = new Sunny.UI.UITextBox();
            uiTextBox2 = new Sunny.UI.UITextBox();
            selectCheck = new DataGridViewCheckBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            Account = new DataGridViewTextBoxColumn();
            IoManage = new DataGridViewTextBoxColumn();
            CameraManage = new DataGridViewTextBoxColumn();
            LogManage = new DataGridViewTextBoxColumn();
            UserManage = new DataGridViewTextBoxColumn();
            CountManage = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Uid = new DataGridViewTextBoxColumn();
            Aid = new DataGridViewTextBoxColumn();
            uiGroupBox1.SuspendLayout();
            uiGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            uiGroupBox2.SuspendLayout();
            uiGroupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.Controls.Add(uiGroupBox4);
            uiGroupBox1.Controls.Add(flowLayoutPanel1);
            uiGroupBox1.Dock = DockStyle.Fill;
            uiGroupBox1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiGroupBox1.Location = new Point(0, 0);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.Size = new Size(1258, 617);
            uiGroupBox1.TabIndex = 0;
            uiGroupBox1.Text = "用户管理";
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox4
            // 
            uiGroupBox4.Controls.Add(uiDataGridView1);
            uiGroupBox4.Dock = DockStyle.Fill;
            uiGroupBox4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiGroupBox4.Location = new Point(349, 32);
            uiGroupBox4.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox4.MinimumSize = new Size(1, 1);
            uiGroupBox4.Name = "uiGroupBox4";
            uiGroupBox4.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox4.Size = new Size(909, 585);
            uiGroupBox4.TabIndex = 6;
            uiGroupBox4.Text = "用户列表";
            uiGroupBox4.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // uiDataGridView1
            // 
            uiDataGridView1.AllowUserToAddRows = false;
            uiDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            uiDataGridView1.BackgroundColor = Color.White;
            uiDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            uiDataGridView1.ColumnHeadersHeight = 32;
            uiDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            uiDataGridView1.Columns.AddRange(new DataGridViewColumn[] { selectCheck, UserName, Account, IoManage, CameraManage, LogManage, UserManage, CountManage, Password, Uid, Aid });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            uiDataGridView1.Dock = DockStyle.Fill;
            uiDataGridView1.EnableHeadersVisualStyles = false;
            uiDataGridView1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiDataGridView1.GridColor = Color.FromArgb(80, 160, 255);
            uiDataGridView1.Location = new Point(0, 32);
            uiDataGridView1.Name = "uiDataGridView1";
            uiDataGridView1.ReadOnly = true;
            uiDataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            uiDataGridView1.RowHeadersVisible = false;
            uiDataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            uiDataGridView1.SelectedIndex = -1;
            uiDataGridView1.Size = new Size(909, 553);
            uiDataGridView1.StripeOddColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(uiGroupBox2);
            flowLayoutPanel1.Controls.Add(uiGroupBox3);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 32);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(349, 585);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // uiGroupBox2
            // 
            uiGroupBox2.Controls.Add(uiTextBox4);
            uiGroupBox2.Controls.Add(uiTextBox3);
            uiGroupBox2.Controls.Add(uiLabel2);
            uiGroupBox2.Controls.Add(uiAvatar1);
            uiGroupBox2.Controls.Add(uiLabel1);
            uiGroupBox2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiGroupBox2.Location = new Point(4, 5);
            uiGroupBox2.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox2.MinimumSize = new Size(1, 1);
            uiGroupBox2.Name = "uiGroupBox2";
            uiGroupBox2.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox2.Size = new Size(336, 270);
            uiGroupBox2.TabIndex = 3;
            uiGroupBox2.Text = "用户信息";
            uiGroupBox2.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // uiTextBox4
            // 
            uiTextBox4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTextBox4.Location = new Point(124, 203);
            uiTextBox4.Margin = new Padding(4, 5, 4, 5);
            uiTextBox4.MinimumSize = new Size(1, 16);
            uiTextBox4.Name = "uiTextBox4";
            uiTextBox4.Padding = new Padding(5);
            uiTextBox4.ShowText = false;
            uiTextBox4.Size = new Size(208, 44);
            uiTextBox4.TabIndex = 5;
            uiTextBox4.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox4.Watermark = "";
            // 
            // uiTextBox3
            // 
            uiTextBox3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTextBox3.Location = new Point(124, 124);
            uiTextBox3.Margin = new Padding(4, 5, 4, 5);
            uiTextBox3.MinimumSize = new Size(1, 16);
            uiTextBox3.Name = "uiTextBox3";
            uiTextBox3.Padding = new Padding(5);
            uiTextBox3.ShowText = false;
            uiTextBox3.Size = new Size(208, 44);
            uiTextBox3.TabIndex = 5;
            uiTextBox3.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox3.Watermark = "";
            // 
            // uiLabel2
            // 
            uiLabel2.BackColor = Color.Transparent;
            uiLabel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(8, 213);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(118, 34);
            uiLabel2.TabIndex = 4;
            uiLabel2.Text = "用户密码";
            // 
            // uiAvatar1
            // 
            uiAvatar1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiAvatar1.Location = new Point(8, 35);
            uiAvatar1.MinimumSize = new Size(1, 1);
            uiAvatar1.Name = "uiAvatar1";
            uiAvatar1.Size = new Size(75, 78);
            uiAvatar1.TabIndex = 0;
            uiAvatar1.Text = "uiAvatar1";
            // 
            // uiLabel1
            // 
            uiLabel1.BackColor = Color.Transparent;
            uiLabel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(8, 134);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(118, 34);
            uiLabel1.TabIndex = 4;
            uiLabel1.Text = "用户名";
            // 
            // uiGroupBox3
            // 
            uiGroupBox3.Controls.Add(uiButton4);
            uiGroupBox3.Controls.Add(uiButton3);
            uiGroupBox3.Controls.Add(uiButton2);
            uiGroupBox3.Controls.Add(uiButton1);
            uiGroupBox3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiGroupBox3.Location = new Point(4, 285);
            uiGroupBox3.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox3.MinimumSize = new Size(1, 1);
            uiGroupBox3.Name = "uiGroupBox3";
            uiGroupBox3.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox3.Size = new Size(336, 291);
            uiGroupBox3.TabIndex = 4;
            uiGroupBox3.Text = "用户操作";
            uiGroupBox3.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // uiButton4
            // 
            uiButton4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton4.Location = new Point(55, 225);
            uiButton4.MinimumSize = new Size(1, 1);
            uiButton4.Name = "uiButton4";
            uiButton4.Size = new Size(226, 46);
            uiButton4.TabIndex = 0;
            uiButton4.Text = "刷新";
            uiButton4.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // uiButton3
            // 
            uiButton3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton3.Location = new Point(55, 167);
            uiButton3.MinimumSize = new Size(1, 1);
            uiButton3.Name = "uiButton3";
            uiButton3.Size = new Size(226, 46);
            uiButton3.TabIndex = 0;
            uiButton3.Text = "删除用户";
            uiButton3.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // uiButton2
            // 
            uiButton2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton2.Location = new Point(55, 109);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.Size = new Size(226, 46);
            uiButton2.TabIndex = 0;
            uiButton2.Text = "修改用户";
            uiButton2.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton1.Location = new Point(55, 51);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(226, 46);
            uiButton1.TabIndex = 0;
            uiButton1.Text = "添加用户";
            uiButton1.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // uiTextBox1
            // 
            uiTextBox1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTextBox1.Location = new Point(131, 115);
            uiTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiTextBox1.MinimumSize = new Size(1, 16);
            uiTextBox1.Name = "uiTextBox1";
            uiTextBox1.Padding = new Padding(5);
            uiTextBox1.ShowText = false;
            uiTextBox1.Size = new Size(199, 44);
            uiTextBox1.TabIndex = 2;
            uiTextBox1.Text = "uiTextBox1";
            uiTextBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox1.Watermark = "";
            // 
            // uiTextBox2
            // 
            uiTextBox2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTextBox2.Location = new Point(131, 194);
            uiTextBox2.Margin = new Padding(4, 5, 4, 5);
            uiTextBox2.MinimumSize = new Size(1, 16);
            uiTextBox2.Name = "uiTextBox2";
            uiTextBox2.Padding = new Padding(5);
            uiTextBox2.ShowText = false;
            uiTextBox2.Size = new Size(199, 44);
            uiTextBox2.TabIndex = 3;
            uiTextBox2.Text = "uiTextBox2";
            uiTextBox2.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox2.Watermark = "";
            // 
            // selectCheck
            // 
            selectCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            selectCheck.HeaderText = "选择";
            selectCheck.MinimumWidth = 75;
            selectCheck.Name = "selectCheck";
            selectCheck.ReadOnly = true;
            selectCheck.Width = 75;
            // 
            // UserName
            // 
            UserName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UserName.HeaderText = "姓名";
            UserName.MinimumWidth = 50;
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            // 
            // Account
            // 
            Account.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            Account.HeaderText = "账号";
            Account.MinimumWidth = 120;
            Account.Name = "Account";
            Account.ReadOnly = true;
            Account.Width = 120;
            // 
            // IoManage
            // 
            IoManage.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            IoManage.HeaderText = "IO管理";
            IoManage.MinimumWidth = 120;
            IoManage.Name = "IoManage";
            IoManage.ReadOnly = true;
            IoManage.Width = 120;
            // 
            // CameraManage
            // 
            CameraManage.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            CameraManage.HeaderText = "相机管理";
            CameraManage.MinimumWidth = 120;
            CameraManage.Name = "CameraManage";
            CameraManage.ReadOnly = true;
            CameraManage.Width = 120;
            // 
            // LogManage
            // 
            LogManage.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            LogManage.HeaderText = "日志管理";
            LogManage.MinimumWidth = 120;
            LogManage.Name = "LogManage";
            LogManage.ReadOnly = true;
            LogManage.Width = 120;
            // 
            // UserManage
            // 
            UserManage.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            UserManage.HeaderText = "用户管理";
            UserManage.MinimumWidth = 120;
            UserManage.Name = "UserManage";
            UserManage.ReadOnly = true;
            UserManage.Width = 120;
            // 
            // CountManage
            // 
            CountManage.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            CountManage.HeaderText = "产量管理";
            CountManage.MinimumWidth = 120;
            CountManage.Name = "CountManage";
            CountManage.ReadOnly = true;
            CountManage.Width = 120;
            // 
            // Password
            // 
            Password.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            Password.HeaderText = "密码";
            Password.MinimumWidth = 120;
            Password.Name = "Password";
            Password.ReadOnly = true;
            Password.Visible = false;
            Password.Width = 120;
            // 
            // Uid
            // 
            Uid.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            Uid.HeaderText = "用户id";
            Uid.MinimumWidth = 120;
            Uid.Name = "Uid";
            Uid.ReadOnly = true;
            Uid.Visible = false;
            Uid.Width = 120;
            // 
            // Aid
            // 
            Aid.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            Aid.HeaderText = "权限id";
            Aid.MinimumWidth = 120;
            Aid.Name = "Aid";
            Aid.ReadOnly = true;
            Aid.Visible = false;
            Aid.Width = 120;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 617);
            Controls.Add(uiGroupBox1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "UserForm";
            Text = "UserForm";
            uiGroupBox1.ResumeLayout(false);
            uiGroupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            uiGroupBox2.ResumeLayout(false);
            uiGroupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIGroupBox uiGroupBox3;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UITextBox uiTextBox4;
        private Sunny.UI.UITextBox uiTextBox3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UITextBox uiTextBox2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Sunny.UI.UIGroupBox uiGroupBox4;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private Sunny.UI.UIButton uiButton4;
        private Sunny.UI.UIButton uiButton3;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton1;
        private DataGridViewCheckBoxColumn selectCheck;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Account;
        private DataGridViewTextBoxColumn IoManage;
        private DataGridViewTextBoxColumn CameraManage;
        private DataGridViewTextBoxColumn LogManage;
        private DataGridViewTextBoxColumn UserManage;
        private DataGridViewTextBoxColumn CountManage;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Uid;
        private DataGridViewTextBoxColumn Aid;
    }
}