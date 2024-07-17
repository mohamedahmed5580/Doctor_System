namespace Doctor_System
{
    partial class Statements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statements));
            button2 = new Button();
            dataGridView_show2 = new DataGridView();
            label18 = new Label();
            button1 = new Button();
            ty = new TextBox();
            label12 = new Label();
            tm = new TextBox();
            label13 = new Label();
            label14 = new Label();
            td = new TextBox();
            fy = new TextBox();
            label15 = new Label();
            fm = new TextBox();
            label16 = new Label();
            label17 = new Label();
            fd = new TextBox();
            button5 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_show2).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.AccessibleRole = AccessibleRole.Clock;
            button2.BackColor = Color.Red;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(1801, 32);
            button2.Name = "button2";
            button2.Size = new Size(108, 59);
            button2.TabIndex = 136;
            button2.Text = "رجوع";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView_show2
            // 
            dataGridView_show2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_show2.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView_show2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_show2.GridColor = SystemColors.HighlightText;
            dataGridView_show2.Location = new Point(12, 142);
            dataGridView_show2.Margin = new Padding(3, 4, 3, 4);
            dataGridView_show2.Name = "dataGridView_show2";
            dataGridView_show2.RowHeadersWidth = 40;
            dataGridView_show2.RowTemplate.Height = 40;
            dataGridView_show2.Size = new Size(1904, 718);
            dataGridView_show2.TabIndex = 134;
            dataGridView_show2.CellContentClick += dataGridView_show2_CellContentClick;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            label18.Location = new Point(34, 73);
            label18.Name = "label18";
            label18.Size = new Size(162, 36);
            label18.TabIndex = 151;
            label18.Text = "بحث بالتاريخ :";
            // 
            // button1
            // 
            button1.AccessibleRole = AccessibleRole.Clock;
            button1.BackColor = Color.FromArgb(30, 136, 229);
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(980, 68);
            button1.Name = "button1";
            button1.Size = new Size(96, 42);
            button1.TabIndex = 150;
            button1.Text = "بحث";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ty
            // 
            ty.BackColor = Color.White;
            ty.Font = new Font("Segoe UI", 13F);
            ty.Location = new Point(867, 72);
            ty.Margin = new Padding(3, 4, 3, 4);
            ty.Name = "ty";
            ty.PlaceholderText = "YYYY";
            ty.Size = new Size(95, 36);
            ty.TabIndex = 149;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.AliceBlue;
            label12.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label12.Location = new Point(738, 74);
            label12.Name = "label12";
            label12.Size = new Size(26, 35);
            label12.TabIndex = 148;
            label12.Text = "/";
            // 
            // tm
            // 
            tm.BackColor = Color.White;
            tm.Font = new Font("Segoe UI", 13F);
            tm.Location = new Point(767, 72);
            tm.Margin = new Padding(3, 4, 3, 4);
            tm.Name = "tm";
            tm.PlaceholderText = "MM";
            tm.Size = new Size(65, 36);
            tm.TabIndex = 147;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.AliceBlue;
            label13.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label13.Location = new Point(835, 75);
            label13.Name = "label13";
            label13.Size = new Size(26, 35);
            label13.TabIndex = 146;
            label13.Text = "/";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.AliceBlue;
            label14.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label14.Location = new Point(584, 65);
            label14.Name = "label14";
            label14.Size = new Size(77, 46);
            label14.TabIndex = 145;
            label14.Text = "الى:";
            // 
            // td
            // 
            td.BackColor = Color.White;
            td.Font = new Font("Segoe UI", 13F);
            td.Location = new Point(690, 75);
            td.Margin = new Padding(3, 4, 3, 4);
            td.Name = "td";
            td.PlaceholderText = "DD";
            td.Size = new Size(46, 36);
            td.TabIndex = 144;
            // 
            // fy
            // 
            fy.BackColor = Color.White;
            fy.Font = new Font("Segoe UI", 13F);
            fy.Location = new Point(474, 68);
            fy.Margin = new Padding(3, 4, 3, 4);
            fy.Name = "fy";
            fy.PlaceholderText = "YYYY";
            fy.Size = new Size(95, 36);
            fy.TabIndex = 143;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.AliceBlue;
            label15.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label15.Location = new Point(347, 69);
            label15.Name = "label15";
            label15.Size = new Size(26, 35);
            label15.TabIndex = 142;
            label15.Text = "/";
            // 
            // fm
            // 
            fm.BackColor = Color.White;
            fm.Font = new Font("Segoe UI", 13F);
            fm.Location = new Point(376, 68);
            fm.Margin = new Padding(3, 4, 3, 4);
            fm.Name = "fm";
            fm.PlaceholderText = "MM";
            fm.Size = new Size(65, 36);
            fm.TabIndex = 141;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.AliceBlue;
            label16.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label16.Location = new Point(444, 69);
            label16.Name = "label16";
            label16.Size = new Size(26, 35);
            label16.TabIndex = 140;
            label16.Text = "/";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.AliceBlue;
            label17.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label17.Location = new Point(193, 61);
            label17.Name = "label17";
            label17.Size = new Size(72, 46);
            label17.TabIndex = 139;
            label17.Text = "من:";
            // 
            // fd
            // 
            fd.BackColor = Color.White;
            fd.Font = new Font("Segoe UI", 13F);
            fd.Location = new Point(299, 71);
            fd.Margin = new Padding(3, 4, 3, 4);
            fd.Name = "fd";
            fd.PlaceholderText = "DD";
            fd.Size = new Size(46, 36);
            fd.TabIndex = 138;
            // 
            // button5
            // 
            button5.AccessibleRole = AccessibleRole.Clock;
            button5.BackColor = Color.Yellow;
            button5.BackgroundImageLayout = ImageLayout.Center;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(1107, 71);
            button5.Name = "button5";
            button5.Size = new Size(127, 42);
            button5.TabIndex = 137;
            button5.Text = "تعديل";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.AccessibleRole = AccessibleRole.Clock;
            button3.BackColor = Color.Red;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(1261, 71);
            button3.Name = "button3";
            button3.Size = new Size(108, 42);
            button3.TabIndex = 152;
            button3.Text = "حذف";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Statements
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1924, 863);
            Controls.Add(button3);
            Controls.Add(label18);
            Controls.Add(button1);
            Controls.Add(ty);
            Controls.Add(label12);
            Controls.Add(tm);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(td);
            Controls.Add(fy);
            Controls.Add(label15);
            Controls.Add(fm);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(fd);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(dataGridView_show2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Statements";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "Statements";
            WindowState = FormWindowState.Maximized;
            Load += Statements_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_show2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private DataGridView dataGridView_show2;
        private Label label18;
        private Button button1;
        public TextBox ty;
        private Label label12;
        public TextBox tm;
        private Label label13;
        private Label label14;
        public TextBox td;
        public TextBox fy;
        private Label label15;
        public TextBox fm;
        private Label label16;
        private Label label17;
        public TextBox fd;
        private Button button5;
        private Button button3;
    }
}