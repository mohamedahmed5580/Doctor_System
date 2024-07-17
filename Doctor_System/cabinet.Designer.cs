namespace Lawyer_Sys
{
    partial class cabinet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cabinet));
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button3.Location = new Point(1264, 322);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(385, 183);
            button3.TabIndex = 8;
            button3.Text = "اضافة ايراد يومي";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button1.Location = new Point(160, 322);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(508, 183);
            button1.TabIndex = 9;
            button1.Text = "التقرير الشامل واجمالي الصافي";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button2.Location = new Point(784, 322);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(385, 183);
            button2.TabIndex = 10;
            button2.Text = "التقرير بالتاريخ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.AccessibleRole = AccessibleRole.Clock;
            button4.BackColor = Color.Red;
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(262, 724);
            button4.Name = "button4";
            button4.Size = new Size(137, 59);
            button4.TabIndex = 88;
            button4.Text = "رجوع";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // cabinet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1568, 1033);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "cabinet";
            Text = "الخزنة";
            WindowState = FormWindowState.Maximized;
            Load += cabinet_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button button1;
        private Button button2;
        private Button button4;
    }
}