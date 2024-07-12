namespace Lawyer_Sys
{
    partial class cabinet_report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cabinet_report));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            lblTotalProfit = new Label();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(656, 12);
            label1.Name = "label1";
            label1.Size = new Size(427, 67);
            label1.TabIndex = 0;
            label1.Text = "تقرير الخزنة الشامل";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 137);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.Size = new Size(1562, 517);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button3.Location = new Point(53, 681);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(251, 183);
            button3.TabIndex = 9;
            button3.Text = "اجمالي الصافي";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lblTotalProfit
            // 
            lblTotalProfit.AutoSize = true;
            lblTotalProfit.Font = new Font("Segoe UI", 20F);
            lblTotalProfit.Location = new Point(368, 748);
            lblTotalProfit.Name = "lblTotalProfit";
            lblTotalProfit.Size = new Size(128, 46);
            lblTotalProfit.TabIndex = 13;
            lblTotalProfit.Text = "الصافي";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(942, 748);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(141, 97);
            button1.TabIndex = 14;
            button1.Text = "حذف";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AccessibleRole = AccessibleRole.Clock;
            button2.BackColor = Color.Red;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(1307, 772);
            button2.Name = "button2";
            button2.Size = new Size(137, 59);
            button2.TabIndex = 88;
            button2.Text = "رجوع";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.AccessibleRole = AccessibleRole.Clock;
            button4.BackColor = Color.Lime;
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button4.Location = new Point(1355, 75);
            button4.Name = "button4";
            button4.Size = new Size(143, 43);
            button4.TabIndex = 89;
            button4.Text = "طباعة";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // cabinet_report
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1568, 1033);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblTotalProfit);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "cabinet_report";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "تقرير الخزنة";
            Load += cabinet_report_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button button3;
        private Label lblTotalProfit;
        private Button button1;
        private Button button2;
        private Button button4;
    }
}