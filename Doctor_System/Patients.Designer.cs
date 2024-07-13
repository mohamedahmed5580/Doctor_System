namespace Doctor_System
{
    partial class Patients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patients));
            delete_btn = new Button();
            edit_btn = new Button();
            label3 = new Label();
            search_btn = new Button();
            label2 = new Label();
            locationp = new TextBox();
            label4 = new Label();
            label5 = new Label();
            age = new TextBox();
            label6 = new Label();
            description = new TextBox();
            chouse = new ComboBox();
            textBox1 = new TextBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            label8 = new Label();
            add_btn = new Button();
            waiting_btn = new Button();
            label10 = new Label();
            nanumberp = new TextBox();
            button1 = new Button();
            label11 = new Label();
            comboBox2 = new ComboBox();
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
            button2 = new Button();
            button3 = new Button();
            numberp = new TextBox();
            namep = new TextBox();
            label9 = new Label();
            label1 = new Label();
            idp = new TextBox();
            dataGridView_show = new DataGridView();
            label20 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label18 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_show).BeginInit();
            SuspendLayout();
            // 
            // delete_btn
            // 
            delete_btn.AccessibleRole = AccessibleRole.Clock;
            delete_btn.BackColor = Color.Red;
            delete_btn.BackgroundImageLayout = ImageLayout.Center;
            delete_btn.FlatStyle = FlatStyle.Flat;
            delete_btn.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            delete_btn.ForeColor = SystemColors.ButtonHighlight;
            delete_btn.Location = new Point(809, 879);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(143, 41);
            delete_btn.TabIndex = 81;
            delete_btn.Text = "حذف";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // edit_btn
            // 
            edit_btn.AccessibleRole = AccessibleRole.Clock;
            edit_btn.BackColor = Color.FromArgb(255, 118, 118);
            edit_btn.BackgroundImageLayout = ImageLayout.Center;
            edit_btn.FlatStyle = FlatStyle.Flat;
            edit_btn.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            edit_btn.ForeColor = SystemColors.ButtonHighlight;
            edit_btn.Location = new Point(651, 879);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(123, 41);
            edit_btn.TabIndex = 80;
            edit_btn.Text = "تعديل";
            edit_btn.UseVisualStyleBackColor = false;
            edit_btn.Click += edit_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            label3.Location = new Point(16, 148);
            label3.Name = "label3";
            label3.Size = new Size(137, 36);
            label3.TabIndex = 78;
            label3.Text = "رقم الهاتف:";
            // 
            // search_btn
            // 
            search_btn.AccessibleRole = AccessibleRole.Clock;
            search_btn.BackColor = Color.FromArgb(30, 136, 229);
            search_btn.BackgroundImageLayout = ImageLayout.Center;
            search_btn.FlatStyle = FlatStyle.Flat;
            search_btn.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            search_btn.ForeColor = SystemColors.ButtonHighlight;
            search_btn.Location = new Point(1764, 752);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(96, 42);
            search_btn.TabIndex = 62;
            search_btn.Text = "بحث";
            search_btn.UseVisualStyleBackColor = false;
            search_btn.Click += search_btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            label2.Location = new Point(15, 213);
            label2.Name = "label2";
            label2.Size = new Size(99, 36);
            label2.TabIndex = 87;
            label2.Text = "العنوان:";
            label2.Click += label2_Click;
            // 
            // locationp
            // 
            locationp.BackColor = Color.White;
            locationp.Font = new Font("Segoe UI", 13F);
            locationp.Location = new Point(179, 214);
            locationp.Margin = new Padding(3, 4, 3, 4);
            locationp.Name = "locationp";
            locationp.PlaceholderText = "العنوان";
            locationp.Size = new Size(411, 36);
            locationp.TabIndex = 86;
            locationp.TextChanged += locationp_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            label4.Location = new Point(1470, 749);
            label4.Name = "label4";
            label4.Size = new Size(130, 36);
            label4.TabIndex = 95;
            label4.Text = "نوع البحث:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            label5.Location = new Point(12, 344);
            label5.Name = "label5";
            label5.Size = new Size(79, 36);
            label5.TabIndex = 94;
            label5.Text = "العمر:";
            // 
            // age
            // 
            age.BackColor = Color.White;
            age.Font = new Font("Segoe UI", 13F);
            age.Location = new Point(179, 349);
            age.Margin = new Padding(3, 4, 3, 4);
            age.Name = "age";
            age.PlaceholderText = "العمر";
            age.Size = new Size(411, 36);
            age.TabIndex = 92;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            label6.Location = new Point(16, 281);
            label6.Name = "label6";
            label6.Size = new Size(121, 36);
            label6.TabIndex = 91;
            label6.Text = "ملاحظات:";
            // 
            // description
            // 
            description.BackColor = Color.White;
            description.Font = new Font("Segoe UI", 13F);
            description.Location = new Point(182, 283);
            description.Margin = new Padding(3, 4, 3, 4);
            description.Name = "description";
            description.PlaceholderText = "ملاحظات";
            description.Size = new Size(408, 36);
            description.TabIndex = 89;
            // 
            // chouse
            // 
            chouse.DropDownHeight = 90;
            chouse.FormattingEnabled = true;
            chouse.IntegralHeight = false;
            chouse.Items.AddRange(new object[] { "اسم المريض", "رقم المريض", "العنوان المريض", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" });
            chouse.Location = new Point(1605, 757);
            chouse.MaxDropDownItems = 5;
            chouse.Name = "chouse";
            chouse.Size = new Size(139, 28);
            chouse.TabIndex = 70;
            chouse.SelectedIndexChanged += chouse_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Segoe UI", 13F);
            textBox1.Location = new Point(1248, 752);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "البحث بالاسم";
            textBox1.Size = new Size(221, 36);
            textBox1.TabIndex = 100;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            label7.Location = new Point(1163, 750);
            label7.Name = "label7";
            label7.Size = new Size(70, 36);
            label7.TabIndex = 101;
            label7.Text = "بحث:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ذكر", "انثي" });
            comboBox1.Location = new Point(182, 476);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(408, 28);
            comboBox1.TabIndex = 102;
            comboBox1.Text = "ذكر";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            label8.Location = new Point(16, 471);
            label8.Name = "label8";
            label8.Size = new Size(75, 36);
            label8.TabIndex = 103;
            label8.Text = "النوع:";
            label8.Click += label8_Click;
            // 
            // add_btn
            // 
            add_btn.AccessibleRole = AccessibleRole.Clock;
            add_btn.BackColor = Color.Lime;
            add_btn.BackgroundImageLayout = ImageLayout.Center;
            add_btn.FlatStyle = FlatStyle.Flat;
            add_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            add_btn.ForeColor = SystemColors.Desktop;
            add_btn.Location = new Point(974, 881);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(153, 42);
            add_btn.TabIndex = 104;
            add_btn.Text = "اضافة مريض";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // waiting_btn
            // 
            waiting_btn.AccessibleRole = AccessibleRole.Clock;
            waiting_btn.BackColor = Color.Yellow;
            waiting_btn.BackgroundImageLayout = ImageLayout.Center;
            waiting_btn.FlatStyle = FlatStyle.Flat;
            waiting_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            waiting_btn.ForeColor = SystemColors.ActiveCaptionText;
            waiting_btn.Location = new Point(1147, 881);
            waiting_btn.Name = "waiting_btn";
            waiting_btn.Size = new Size(153, 42);
            waiting_btn.TabIndex = 105;
            waiting_btn.Text = "تسجيل انتظار";
            waiting_btn.UseVisualStyleBackColor = false;
            waiting_btn.Click += waiting_btn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            label10.Location = new Point(-5, 415);
            label10.Name = "label10";
            label10.Size = new Size(178, 36);
            label10.TabIndex = 84;
            label10.Text = "المبلغ المدفوع:";
            // 
            // nanumberp
            // 
            nanumberp.BackColor = Color.White;
            nanumberp.Font = new Font("Segoe UI", 13F);
            nanumberp.Location = new Point(177, 420);
            nanumberp.Margin = new Padding(3, 4, 3, 4);
            nanumberp.Name = "nanumberp";
            nanumberp.PlaceholderText = "المبلغ المدفوع";
            nanumberp.Size = new Size(411, 36);
            nanumberp.TabIndex = 82;
            // 
            // button1
            // 
            button1.AccessibleRole = AccessibleRole.Clock;
            button1.BackColor = Color.Navy;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(519, 876);
            button1.Name = "button1";
            button1.Size = new Size(96, 46);
            button1.TabIndex = 106;
            button1.Text = "تفريغ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            label11.Location = new Point(-4, 541);
            label11.Name = "label11";
            label11.Size = new Size(150, 36);
            label11.TabIndex = 108;
            label11.Text = " نوع الكشف:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "كشف", "أعادة", "متابعة", "كشف مجاني" });
            comboBox2.Location = new Point(181, 546);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(408, 28);
            comboBox2.TabIndex = 107;
            comboBox2.Text = "كشف";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // ty
            // 
            ty.BackColor = Color.White;
            ty.Font = new Font("Segoe UI", 13F);
            ty.Location = new Point(866, 754);
            ty.Margin = new Padding(3, 4, 3, 4);
            ty.Name = "ty";
            ty.PlaceholderText = "YYYY";
            ty.Size = new Size(95, 36);
            ty.TabIndex = 120;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.AliceBlue;
            label12.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label12.Location = new Point(737, 756);
            label12.Name = "label12";
            label12.Size = new Size(26, 35);
            label12.TabIndex = 119;
            label12.Text = "/";
            // 
            // tm
            // 
            tm.BackColor = Color.White;
            tm.Font = new Font("Segoe UI", 13F);
            tm.Location = new Point(766, 754);
            tm.Margin = new Padding(3, 4, 3, 4);
            tm.Name = "tm";
            tm.PlaceholderText = "MM";
            tm.Size = new Size(65, 36);
            tm.TabIndex = 118;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.AliceBlue;
            label13.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label13.Location = new Point(834, 757);
            label13.Name = "label13";
            label13.Size = new Size(26, 35);
            label13.TabIndex = 117;
            label13.Text = "/";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.AliceBlue;
            label14.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label14.Location = new Point(583, 747);
            label14.Name = "label14";
            label14.Size = new Size(77, 46);
            label14.TabIndex = 116;
            label14.Text = "الى:";
            // 
            // td
            // 
            td.BackColor = Color.White;
            td.Font = new Font("Segoe UI", 13F);
            td.Location = new Point(689, 757);
            td.Margin = new Padding(3, 4, 3, 4);
            td.Name = "td";
            td.PlaceholderText = "DD";
            td.Size = new Size(46, 36);
            td.TabIndex = 115;
            // 
            // fy
            // 
            fy.BackColor = Color.White;
            fy.Font = new Font("Segoe UI", 13F);
            fy.Location = new Point(473, 750);
            fy.Margin = new Padding(3, 4, 3, 4);
            fy.Name = "fy";
            fy.PlaceholderText = "YYYY";
            fy.Size = new Size(95, 36);
            fy.TabIndex = 114;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.AliceBlue;
            label15.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label15.Location = new Point(346, 751);
            label15.Name = "label15";
            label15.Size = new Size(26, 35);
            label15.TabIndex = 113;
            label15.Text = "/";
            // 
            // fm
            // 
            fm.BackColor = Color.White;
            fm.Font = new Font("Segoe UI", 13F);
            fm.Location = new Point(375, 750);
            fm.Margin = new Padding(3, 4, 3, 4);
            fm.Name = "fm";
            fm.PlaceholderText = "MM";
            fm.Size = new Size(65, 36);
            fm.TabIndex = 112;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.AliceBlue;
            label16.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label16.Location = new Point(443, 751);
            label16.Name = "label16";
            label16.Size = new Size(26, 35);
            label16.TabIndex = 111;
            label16.Text = "/";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.AliceBlue;
            label17.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label17.Location = new Point(192, 743);
            label17.Name = "label17";
            label17.Size = new Size(72, 46);
            label17.TabIndex = 110;
            label17.Text = "من:";
            // 
            // fd
            // 
            fd.BackColor = Color.White;
            fd.Font = new Font("Segoe UI", 13F);
            fd.Location = new Point(298, 753);
            fd.Margin = new Padding(3, 4, 3, 4);
            fd.Name = "fd";
            fd.PlaceholderText = "DD";
            fd.Size = new Size(46, 36);
            fd.TabIndex = 109;
            // 
            // button2
            // 
            button2.AccessibleRole = AccessibleRole.Clock;
            button2.BackColor = Color.FromArgb(30, 136, 229);
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(979, 750);
            button2.Name = "button2";
            button2.Size = new Size(96, 42);
            button2.TabIndex = 121;
            button2.Text = "بحث";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.AccessibleRole = AccessibleRole.Clock;
            button3.BackColor = Color.Red;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(1749, 891);
            button3.Name = "button3";
            button3.Size = new Size(143, 41);
            button3.TabIndex = 122;
            button3.Text = "رجوع";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // numberp
            // 
            numberp.BackColor = Color.White;
            numberp.Font = new Font("Segoe UI", 13F);
            numberp.Location = new Point(182, 150);
            numberp.Margin = new Padding(3, 4, 3, 4);
            numberp.Name = "numberp";
            numberp.PlaceholderText = "رقم الهاتف";
            numberp.Size = new Size(408, 36);
            numberp.TabIndex = 76;
            // 
            // namep
            // 
            namep.BackColor = Color.White;
            namep.Font = new Font("Segoe UI", 13F);
            namep.Location = new Point(182, 83);
            namep.Margin = new Padding(3, 4, 3, 4);
            namep.Name = "namep";
            namep.PlaceholderText = "الاسم";
            namep.Size = new Size(408, 36);
            namep.TabIndex = 75;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            label9.Location = new Point(12, 80);
            label9.Name = "label9";
            label9.Size = new Size(161, 36);
            label9.TabIndex = 77;
            label9.Text = "اسم المريض:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            label1.Location = new Point(15, 23);
            label1.Name = "label1";
            label1.Size = new Size(154, 36);
            label1.TabIndex = 99;
            label1.Text = "رقم المريض:";
            // 
            // idp
            // 
            idp.BackColor = Color.White;
            idp.Font = new Font("Segoe UI", 13F);
            idp.Location = new Point(179, 25);
            idp.Margin = new Padding(3, 4, 3, 4);
            idp.Name = "idp";
            idp.PlaceholderText = "رقم المريض";
            idp.ReadOnly = true;
            idp.Size = new Size(411, 36);
            idp.TabIndex = 98;
            idp.TextChanged += idp_TextChanged;
            // 
            // dataGridView_show
            // 
            dataGridView_show.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_show.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView_show.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView_show.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_show.GridColor = SystemColors.HighlightText;
            dataGridView_show.Location = new Point(607, 23);
            dataGridView_show.Margin = new Padding(3, 4, 3, 4);
            dataGridView_show.Name = "dataGridView_show";
            dataGridView_show.RowHeadersWidth = 40;
            dataGridView_show.RowTemplate.Height = 40;
            dataGridView_show.Size = new Size(1305, 633);
            dataGridView_show.TabIndex = 40;
            dataGridView_show.CellContentClick += dataGridView_show_CellContentClick;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            label20.Location = new Point(-5, 617);
            label20.Name = "label20";
            label20.Size = new Size(166, 36);
            label20.TabIndex = 123;
            label20.Text = " تاريخ الكشف:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(192, 625);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(286, 27);
            dateTimePicker1.TabIndex = 124;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            label18.Location = new Point(33, 755);
            label18.Name = "label18";
            label18.Size = new Size(162, 36);
            label18.TabIndex = 125;
            label18.Text = "بحث بالتاريخ :";
            // 
            // Patients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1924, 950);
            Controls.Add(label18);
            Controls.Add(dateTimePicker1);
            Controls.Add(label20);
            Controls.Add(button3);
            Controls.Add(button2);
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
            Controls.Add(label11);
            Controls.Add(comboBox2);
            Controls.Add(button1);
            Controls.Add(waiting_btn);
            Controls.Add(add_btn);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(idp);
            Controls.Add(chouse);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(age);
            Controls.Add(label6);
            Controls.Add(description);
            Controls.Add(label2);
            Controls.Add(locationp);
            Controls.Add(label10);
            Controls.Add(nanumberp);
            Controls.Add(delete_btn);
            Controls.Add(edit_btn);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(numberp);
            Controls.Add(namep);
            Controls.Add(search_btn);
            Controls.Add(dataGridView_show);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(80, 20);
            Name = "Patients";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.Manual;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Patients_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_show).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button delete_btn;
        private Button edit_btn;
        private Label label3;
        private Button search_btn;
        private Label label2;
        public TextBox locationp;
        private Label label4;
        private Label label5;
        public TextBox age;
        private Label label6;
        public TextBox description;
        private ComboBox chouse;
        public TextBox textBox1;
        private Label label7;
        private ComboBox comboBox1;
        private Label label8;
        private Button add_btn;
        private Button waiting_btn;
        private Label label10;
        public TextBox nanumberp;
        private Button button1;
        private Label label11;
        private ComboBox comboBox2;
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
        private Button button2;
        private Button button3;
        public TextBox numberp;
        public TextBox namep;
        private Label label9;
        private Label label1;
        public TextBox idp;
        private DataGridView dataGridView_show;
        private Label label20;
        private DateTimePicker dateTimePicker1;
        private Label label18;
    }
}