namespace Hospital
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            password = new TextBox();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            name = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(837, 136);
            label1.Name = "label1";
            label1.Size = new Size(283, 60);
            label1.TabIndex = 1;
            label1.Text = " عيادة دكتور   ";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(837, 252);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(573, 676);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Elephant", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(287, 252);
            label2.Name = "label2";
            label2.Size = new Size(285, 60);
            label2.TabIndex = 3;
            label2.Text = "هل انت جاهز؟";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(128, 408);
            label3.Name = "label3";
            label3.Size = new Size(204, 42);
            label3.TabIndex = 4;
            label3.Text = "اسم المستخدم:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(128, 639);
            label5.Name = "label5";
            label5.Size = new Size(186, 42);
            label5.TabIndex = 6;
            label5.Text = "كلمة المرور:";
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            password.Location = new Point(237, 745);
            password.Margin = new Padding(3, 4, 3, 4);
            password.Multiline = true;
            password.Name = "password";
            password.Size = new Size(308, 59);
            password.TabIndex = 8;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(293, 877);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(227, 75);
            button2.TabIndex = 9;
            button2.Text = "تسجيل الدخول";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(586, 136);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(162, 155);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(95, 136);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(162, 155);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // name
            // 
            name.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            name.Location = new Point(237, 503);
            name.Margin = new Padding(3, 4, 3, 4);
            name.Multiline = true;
            name.Name = "name";
            name.Size = new Size(308, 59);
            name.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1568, 1033);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(password);
            Controls.Add(name);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "تسجيل الدخول";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox password;
        private Button button2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox name;
    }
}
