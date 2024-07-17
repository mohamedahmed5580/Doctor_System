namespace Hospital.Forms
{
    partial class basic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(basic));
            pictureBox1 = new PictureBox();
            pictureBox5 = new PictureBox();
            button5 = new Button();
            welcome = new Label();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(348, 309);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 177);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1433, 294);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(163, 177);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.Font = new Font("Times New Roman", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.ImageAlign = ContentAlignment.TopCenter;
            button5.Location = new Point(1401, 580);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(211, 160);
            button5.TabIndex = 8;
            button5.Text = "الحسابات";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // welcome
            // 
            welcome.AutoSize = true;
            welcome.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            welcome.Location = new Point(917, 128);
            welcome.Name = "welcome";
            welcome.Size = new Size(198, 62);
            welcome.TabIndex = 11;
            welcome.Text = "مرحبا بك";
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1096, 309);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(163, 177);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Times New Roman", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(1069, 572);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(210, 160);
            button2.TabIndex = 12;
            button2.Text = "الكشوفات";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Times New Roman", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(709, 572);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(210, 160);
            button1.TabIndex = 16;
            button1.Text = "قائمة الانتظار";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Times New Roman", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.Location = new Point(330, 572);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(210, 160);
            button3.TabIndex = 17;
            button3.Text = "المرضى";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(739, 309);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(163, 177);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // basic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1846, 1033);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(welcome);
            Controls.Add(pictureBox5);
            Controls.Add(button5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "basic";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "الواجهة الرئيسية";
            WindowState = FormWindowState.Maximized;
            Load += basic_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private Button button5;
        private Label welcome;
        private PictureBox pictureBox2;
        private Button button2;
        private Button button1;
        private Button button3;
        private PictureBox pictureBox4;
    }
}