namespace Doctor_System
{
    partial class editPrescription
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
            namepp = new TextBox();
            button1 = new Button();
            label4 = new Label();
            quantity = new TextBox();
            Disease = new TextBox();
            richTextBox1 = new RichTextBox();
            label17 = new Label();
            label18 = new Label();
            location = new TextBox();
            label3 = new Label();
            datein = new TextBox();
            type = new TextBox();
            label11 = new Label();
            label2 = new Label();
            label1 = new Label();
            idpp = new TextBox();
            label9 = new Label();
            label5 = new Label();
            preIdTextBox = new TextBox();
            SuspendLayout();
            // 
            // namepp
            // 
            namepp.BackColor = Color.White;
            namepp.Font = new Font("Segoe UI", 13F);
            namepp.Location = new Point(873, 130);
            namepp.Margin = new Padding(3, 4, 3, 4);
            namepp.Name = "namepp";
            namepp.PlaceholderText = "اسم المريض";
            namepp.ReadOnly = true;
            namepp.Size = new Size(411, 36);
            namepp.TabIndex = 195;
            // 
            // button1
            // 
            button1.AccessibleRole = AccessibleRole.Clock;
            button1.BackColor = Color.Lime;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Desktop;
            button1.Location = new Point(940, 511);
            button1.Name = "button1";
            button1.Size = new Size(260, 42);
            button1.TabIndex = 194;
            button1.Text = "حفظ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            label4.Location = new Point(718, 346);
            label4.Name = "label4";
            label4.Size = new Size(141, 36);
            label4.TabIndex = 193;
            label4.Text = "عدد المرات:";
            // 
            // quantity
            // 
            quantity.BackColor = Color.White;
            quantity.Font = new Font("Segoe UI", 13F);
            quantity.Location = new Point(887, 346);
            quantity.Margin = new Padding(3, 4, 3, 4);
            quantity.Name = "quantity";
            quantity.Size = new Size(147, 36);
            quantity.TabIndex = 192;
            // 
            // Disease
            // 
            Disease.BackColor = Color.White;
            Disease.Font = new Font("Segoe UI", 13F);
            Disease.Location = new Point(882, 270);
            Disease.Margin = new Padding(3, 4, 3, 4);
            Disease.Name = "Disease";
            Disease.PlaceholderText = "نوع المرض";
            Disease.Size = new Size(286, 36);
            Disease.TabIndex = 191;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(214, 291);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(423, 125);
            richTextBox1.TabIndex = 190;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            label17.Location = new Point(709, 268);
            label17.Name = "label17";
            label17.Size = new Size(141, 36);
            label17.TabIndex = 188;
            label17.Text = "نوع المرض:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            label18.Location = new Point(84, 281);
            label18.Name = "label18";
            label18.Size = new Size(115, 36);
            label18.TabIndex = 187;
            label18.Text = "العلاجات:";
            // 
            // location
            // 
            location.BackColor = Color.White;
            location.Font = new Font("Segoe UI", 13F);
            location.Location = new Point(876, 195);
            location.Margin = new Padding(3, 4, 3, 4);
            location.Name = "location";
            location.PlaceholderText = " عنوان الكشف";
            location.ReadOnly = true;
            location.Size = new Size(408, 36);
            location.TabIndex = 186;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            label3.Location = new Point(688, 193);
            label3.Name = "label3";
            label3.Size = new Size(174, 36);
            label3.TabIndex = 185;
            label3.Text = " عنوان الكشف:";
            // 
            // datein
            // 
            datein.BackColor = Color.White;
            datein.Font = new Font("Segoe UI", 13F);
            datein.Location = new Point(229, 203);
            datein.Margin = new Padding(3, 4, 3, 4);
            datein.Name = "datein";
            datein.PlaceholderText = "تاريخ الكشف";
            datein.ReadOnly = true;
            datein.Size = new Size(408, 36);
            datein.TabIndex = 184;
            // 
            // type
            // 
            type.BackColor = Color.White;
            type.Font = new Font("Segoe UI", 13F);
            type.Location = new Point(229, 130);
            type.Margin = new Padding(3, 4, 3, 4);
            type.Name = "type";
            type.PlaceholderText = "نوع الكشف";
            type.ReadOnly = true;
            type.Size = new Size(408, 36);
            type.TabIndex = 183;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            label11.Location = new Point(49, 128);
            label11.Name = "label11";
            label11.Size = new Size(150, 36);
            label11.TabIndex = 182;
            label11.Text = " نوع الكشف:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            label2.Location = new Point(39, 202);
            label2.Name = "label2";
            label2.Size = new Size(159, 36);
            label2.TabIndex = 181;
            label2.Text = "تاريخ الكشف:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            label1.Location = new Point(709, 63);
            label1.Name = "label1";
            label1.Size = new Size(154, 36);
            label1.TabIndex = 180;
            label1.Text = "رقم المريض:";
            label1.UseMnemonic = false;
            // 
            // idpp
            // 
            idpp.BackColor = Color.White;
            idpp.Font = new Font("Segoe UI", 13F);
            idpp.Location = new Point(873, 65);
            idpp.Margin = new Padding(3, 4, 3, 4);
            idpp.Name = "idpp";
            idpp.PlaceholderText = "رقم المريض";
            idpp.ReadOnly = true;
            idpp.Size = new Size(411, 36);
            idpp.TabIndex = 179;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            label9.Location = new Point(701, 126);
            label9.Name = "label9";
            label9.Size = new Size(161, 36);
            label9.TabIndex = 178;
            label9.Text = "اسم المريض:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            label5.Location = new Point(49, 67);
            label5.Name = "label5";
            label5.Size = new Size(143, 36);
            label5.TabIndex = 197;
            label5.Text = "رقم الكشف:";
            label5.UseMnemonic = false;
            // 
            // preIdTextBox
            // 
            preIdTextBox.BackColor = Color.White;
            preIdTextBox.Font = new Font("Segoe UI", 11F);
            preIdTextBox.Location = new Point(229, 69);
            preIdTextBox.Margin = new Padding(3, 4, 3, 4);
            preIdTextBox.Name = "preIdTextBox";
            preIdTextBox.PlaceholderText = "رقم الكشف";
            preIdTextBox.ReadOnly = true;
            preIdTextBox.Size = new Size(126, 32);
            preIdTextBox.TabIndex = 196;
            // 
            // editPrescription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1311, 603);
            Controls.Add(label5);
            Controls.Add(preIdTextBox);
            Controls.Add(namepp);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(quantity);
            Controls.Add(Disease);
            Controls.Add(richTextBox1);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(location);
            Controls.Add(label3);
            Controls.Add(datein);
            Controls.Add(type);
            Controls.Add(label11);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(idpp);
            Controls.Add(label9);
            Name = "editPrescription";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = " ";
            Load += editPrescription_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox namepp;
        private Button button1;
        private Label label4;
        public TextBox quantity;
        public TextBox Disease;
        public RichTextBox richTextBox1;
        private Label label17;
        private Label label18;
        public TextBox location;
        private Label label3;
        public TextBox datein;
        public TextBox type;
        private Label label11;
        private Label label2;
        private Label label1;
        public TextBox idpp;
        private Label label9;
        private Label label5;
        public TextBox preIdTextBox;
    }
}