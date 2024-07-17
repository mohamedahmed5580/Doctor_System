namespace Lawyer_Sys
{
    partial class Adding_revenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adding_revenue));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.MenuHighlight;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(169, 119);
            label1.Name = "label1";
            label1.Size = new Size(153, 50);
            label1.TabIndex = 34;
            label1.Text = "الايراد اليومي";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.MenuHighlight;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.Location = new Point(169, 257);
            label2.Name = "label2";
            label2.Size = new Size(153, 49);
            label2.TabIndex = 35;
            label2.Text = "المصروفات";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.MenuHighlight;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label3.Location = new Point(185, 404);
            label3.Name = "label3";
            label3.Size = new Size(137, 52);
            label3.TabIndex = 36;
            label3.Text = "الكاش";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.MenuHighlight;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.Location = new Point(152, 565);
            label4.Name = "label4";
            label4.Size = new Size(178, 51);
            label4.TabIndex = 37;
            label4.Text = "الفودافون كاش";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            textBox1.Location = new Point(343, 124);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 45);
            textBox1.TabIndex = 38;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            textBox2.Location = new Point(343, 271);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(494, 45);
            textBox2.TabIndex = 39;
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            textBox3.Location = new Point(343, 411);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(494, 45);
            textBox3.TabIndex = 40;
            textBox3.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            textBox4.Location = new Point(343, 571);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(494, 45);
            textBox4.TabIndex = 41;
            textBox4.TextAlign = HorizontalAlignment.Right;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button2.Location = new Point(616, 756);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(236, 78);
            button2.TabIndex = 42;
            button2.Text = "اضافة الايراد ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.AccessibleRole = AccessibleRole.Clock;
            button1.BackColor = Color.Red;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(1262, 787);
            button1.Name = "button1";
            button1.Size = new Size(137, 59);
            button1.TabIndex = 89;
            button1.Text = "رجوع";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Adding_revenue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1568, 1033);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Adding_revenue";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "اضافة ايراد يومي";
            Load += Adding_revenue_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button2;
        private Button button1;
    }
}