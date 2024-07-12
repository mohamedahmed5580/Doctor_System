namespace Doctor_System
{
    partial class Waiting
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
            dataGridView_show2 = new DataGridView();
            button4 = new Button();
            button2 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_show2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_show2
            // 
            dataGridView_show2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_show2.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView_show2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_show2.GridColor = SystemColors.HighlightText;
            dataGridView_show2.Location = new Point(12, 139);
            dataGridView_show2.Margin = new Padding(3, 4, 3, 4);
            dataGridView_show2.Name = "dataGridView_show2";
            dataGridView_show2.RowHeadersWidth = 40;
            dataGridView_show2.RowTemplate.Height = 40;
            dataGridView_show2.Size = new Size(1904, 718);
            dataGridView_show2.TabIndex = 129;
            dataGridView_show2.CellContentClick += dataGridView_show2_CellContentClick;
            // 
            // button4
            // 
            button4.AccessibleRole = AccessibleRole.Clock;
            button4.BackColor = Color.Lime;
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button4.Location = new Point(34, 29);
            button4.Name = "button4";
            button4.Size = new Size(143, 59);
            button4.TabIndex = 130;
            button4.Text = "تم الحضور";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.AccessibleRole = AccessibleRole.Clock;
            button2.BackColor = Color.Red;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(1801, 29);
            button2.Name = "button2";
            button2.Size = new Size(108, 59);
            button2.TabIndex = 131;
            button2.Text = "رجوع";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.AccessibleRole = AccessibleRole.Clock;
            button5.BackColor = Color.Yellow;
            button5.BackgroundImageLayout = ImageLayout.Center;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(422, 46);
            button5.Name = "button5";
            button5.Size = new Size(217, 42);
            button5.TabIndex = 133;
            button5.Text = "تسجيل الكشف الطبي";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Waiting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1928, 860);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(dataGridView_show2);
            Name = "Waiting";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Waiting_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_show2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView_show2;
        private Button button4;
        private Button button2;
        private Button button5;
    }
}
