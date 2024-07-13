namespace Lawyer_Sys
{
    partial class cabinet_date_search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cabinet_date_search));
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            lblTotalProfit = new Label();
            button2 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 15F, FontStyle.Bold);
            dateTimePicker1.CalendarMonthBackground = SystemColors.Menu;
            dateTimePicker1.Location = new Point(381, 58);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.RightToLeft = RightToLeft.Yes;
            dateTimePicker1.Size = new Size(254, 27);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.Location = new Point(256, 27);
            label1.Name = "label1";
            label1.Size = new Size(91, 67);
            label1.TabIndex = 2;
            label1.Text = "من";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("Segoe UI", 15F, FontStyle.Bold);
            dateTimePicker2.CalendarMonthBackground = SystemColors.Menu;
            dateTimePicker2.Location = new Point(798, 58);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.RightToLeft = RightToLeft.Yes;
            dateTimePicker2.Size = new Size(254, 27);
            dateTimePicker2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label2.Location = new Point(669, 33);
            label2.Name = "label2";
            label2.Size = new Size(101, 67);
            label2.TabIndex = 4;
            label2.Text = "الى";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            button3.Location = new Point(656, 121);
            button3.Name = "button3";
            button3.Size = new Size(114, 62);
            button3.TabIndex = 9;
            button3.Text = "التقرير";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 189);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.Size = new Size(1359, 333);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.Location = new Point(36, 560);
            button1.Name = "button1";
            button1.Size = new Size(254, 83);
            button1.TabIndex = 11;
            button1.Text = "اجمالي صافي الفترة";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblTotalProfit
            // 
            lblTotalProfit.AutoSize = true;
            lblTotalProfit.Font = new Font("Segoe UI", 20F);
            lblTotalProfit.Location = new Point(317, 585);
            lblTotalProfit.Name = "lblTotalProfit";
            lblTotalProfit.Size = new Size(128, 46);
            lblTotalProfit.TabIndex = 14;
            lblTotalProfit.Text = "الصافي";
            // 
            // button2
            // 
            button2.AccessibleRole = AccessibleRole.Clock;
            button2.BackColor = Color.Red;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(989, 576);
            button2.Name = "button2";
            button2.Size = new Size(137, 59);
            button2.TabIndex = 88;
            button2.Text = "رجوع";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button4
            // 
            button4.AccessibleRole = AccessibleRole.Clock;
            button4.BackColor = Color.Lime;
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button4.Location = new Point(1098, 132);
            button4.Name = "button4";
            button4.Size = new Size(143, 42);
            button4.TabIndex = 89;
            button4.Text = "طباعة";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // cabinet_date_search
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1372, 775);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(lblTotalProfit);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(dateTimePicker2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "cabinet_date_search";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "تقرير الخزنة بالبحث";
            Load += cabinet_date_search_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button1;
        private Label lblTotalProfit;
        private Button button2;
        private Button button4;
    }
}