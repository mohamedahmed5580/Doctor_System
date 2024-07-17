namespace Doctor_System
{
    partial class Reservations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservations));
            label1 = new Label();
            idpp = new TextBox();
            label9 = new Label();
            label2 = new Label();
            label11 = new Label();
            datein = new TextBox();
            location = new TextBox();
            label3 = new Label();
            label18 = new Label();
            add_btn = new Button();
            richTextBox1 = new RichTextBox();
            label17 = new Label();
            Disease = new TextBox();
            label4 = new Label();
            quantity = new TextBox();
            button1 = new Button();
            type = new TextBox();
            namepp = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            label1.Location = new Point(718, 26);
            label1.Name = "label1";
            label1.Size = new Size(154, 36);
            label1.TabIndex = 104;
            label1.Text = "رقم المريض:";
            label1.UseMnemonic = false;
            // 
            // idpp
            // 
            idpp.BackColor = Color.White;
            idpp.Font = new Font("Segoe UI", 13F);
            idpp.Location = new Point(882, 28);
            idpp.Margin = new Padding(3, 4, 3, 4);
            idpp.Name = "idpp";
            idpp.PlaceholderText = "رقم المريض";
            idpp.ReadOnly = true;
            idpp.Size = new Size(411, 36);
            idpp.TabIndex = 103;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            label9.Location = new Point(33, 24);
            label9.Name = "label9";
            label9.Size = new Size(161, 36);
            label9.TabIndex = 102;
            label9.Text = "اسم المريض:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            label2.Location = new Point(36, 165);
            label2.Name = "label2";
            label2.Size = new Size(159, 36);
            label2.TabIndex = 128;
            label2.Text = "تاريخ الكشف:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            label11.Location = new Point(46, 91);
            label11.Name = "label11";
            label11.Size = new Size(150, 36);
            label11.TabIndex = 130;
            label11.Text = " نوع الكشف:";
            // 
            // datein
            // 
            datein.BackColor = Color.White;
            datein.Font = new Font("Segoe UI", 13F);
            datein.Location = new Point(234, 166);
            datein.Margin = new Padding(3, 4, 3, 4);
            datein.Name = "datein";
            datein.PlaceholderText = "تاريخ الكشف";
            datein.ReadOnly = true;
            datein.Size = new Size(408, 36);
            datein.TabIndex = 133;
            // 
            // location
            // 
            location.BackColor = Color.White;
            location.Font = new Font("Segoe UI", 13F);
            location.Location = new Point(885, 93);
            location.Margin = new Padding(3, 4, 3, 4);
            location.Name = "location";
            location.PlaceholderText = " عنوان الكشف";
            location.ReadOnly = true;
            location.Size = new Size(408, 36);
            location.TabIndex = 135;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            label3.Location = new Point(697, 91);
            label3.Name = "label3";
            label3.Size = new Size(174, 36);
            label3.TabIndex = 134;
            label3.Text = " عنوان الكشف:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            label18.Location = new Point(98, 244);
            label18.Name = "label18";
            label18.Size = new Size(115, 36);
            label18.TabIndex = 159;
            label18.Text = "العلاجات:";
            // 
            // add_btn
            // 
            add_btn.AccessibleRole = AccessibleRole.Clock;
            add_btn.BackColor = Color.Cyan;
            add_btn.BackgroundImageLayout = ImageLayout.Center;
            add_btn.FlatStyle = FlatStyle.Flat;
            add_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            add_btn.ForeColor = SystemColors.Desktop;
            add_btn.Location = new Point(1000, 546);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(243, 42);
            add_btn.TabIndex = 163;
            add_btn.Text = "طباعة التقرير الطبي";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(219, 254);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(423, 125);
            richTextBox1.TabIndex = 171;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            label17.Location = new Point(718, 166);
            label17.Name = "label17";
            label17.Size = new Size(141, 36);
            label17.TabIndex = 160;
            label17.Text = "نوع المرض:";
            // 
            // Disease
            // 
            Disease.BackColor = Color.White;
            Disease.Font = new Font("Segoe UI", 13F);
            Disease.Location = new Point(891, 168);
            Disease.Margin = new Padding(3, 4, 3, 4);
            Disease.Name = "Disease";
            Disease.PlaceholderText = "نوع المرض";
            Disease.Size = new Size(286, 36);
            Disease.TabIndex = 172;
            Disease.TextChanged += typeoflay_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            label4.Location = new Point(727, 244);
            label4.Name = "label4";
            label4.Size = new Size(141, 36);
            label4.TabIndex = 174;
            label4.Text = "عدد المرات:";
            // 
            // quantity
            // 
            quantity.BackColor = Color.White;
            quantity.Font = new Font("Segoe UI", 13F);
            quantity.Location = new Point(896, 244);
            quantity.Margin = new Padding(3, 4, 3, 4);
            quantity.Name = "quantity";
            quantity.Size = new Size(147, 36);
            quantity.TabIndex = 173;
            quantity.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.AccessibleRole = AccessibleRole.Clock;
            button1.BackColor = Color.Lime;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Desktop;
            button1.Location = new Point(767, 546);
            button1.Name = "button1";
            button1.Size = new Size(124, 42);
            button1.TabIndex = 175;
            button1.Text = "حفظ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // type
            // 
            type.BackColor = Color.White;
            type.Font = new Font("Segoe UI", 13F);
            type.Location = new Point(234, 93);
            type.Margin = new Padding(3, 4, 3, 4);
            type.Name = "type";
            type.PlaceholderText = "نوع الكشف";
            type.ReadOnly = true;
            type.Size = new Size(408, 36);
            type.TabIndex = 131;
            // 
            // namepp
            // 
            namepp.BackColor = Color.White;
            namepp.Font = new Font("Segoe UI", 13F);
            namepp.Location = new Point(234, 28);
            namepp.Margin = new Padding(3, 4, 3, 4);
            namepp.Name = "namepp";
            namepp.PlaceholderText = "اسم المريض";
            namepp.ReadOnly = true;
            namepp.Size = new Size(408, 36);
            namepp.TabIndex = 177;
            // 
            // Reservations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1428, 667);
            Controls.Add(namepp);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(quantity);
            Controls.Add(Disease);
            Controls.Add(richTextBox1);
            Controls.Add(add_btn);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Reservations";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "Form2";
            Load += Reservations_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public TextBox idpp;
        private Label label9;
        private Label label2;
        private Label label11;
        public TextBox datein;
        public TextBox location;
        private Label label3;
        private Label label18;
        private Button add_btn;
        private RichTextBox richTextBox1;
        private Label label17;
        public TextBox Disease;
        private Label label4;
        public TextBox quantity;
        private Button button1;
        public TextBox type;
        public TextBox namepp;
    }
}