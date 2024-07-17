namespace Doctor_System
{
    partial class Report
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            toolTip1 = new ToolTip(components);
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(77, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(1349, 987);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.SizeNESW;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(97, 62);
            label1.Name = "label1";
            label1.Size = new Size(286, 29);
            label1.TabIndex = 1;
            label1.Text = "Diamond Dental Clinic";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(588, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 198);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1387, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 52);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            pictureBox2.MouseHover += pictureBox2_MouseHover;
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.SizeNESW;
            label2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(97, 102);
            label2.Name = "label2";
            label2.Size = new Size(292, 29);
            label2.TabIndex = 2;
            label2.Text = "Dr. Fawzia Yossry EZZ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.SizeNESW;
            label3.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(97, 144);
            label3.Name = "label3";
            label3.Size = new Size(272, 29);
            label3.TabIndex = 3;
            label3.Text = "Phone: 01061085571";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.SizeNESW;
            label4.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(975, 62);
            label4.Name = "label4";
            label4.Size = new Size(315, 29);
            label4.TabIndex = 4;
            label4.Text = "عیادة دایموند لطب الفم و الاستان";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.SizeNESW;
            label5.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(1111, 113);
            label5.Name = "label5";
            label5.Size = new Size(179, 29);
            label5.TabIndex = 5;
            label5.Text = "د.فوزية يسري عز";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.SizeNESW;
            label6.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(1088, 164);
            label6.Name = "label6";
            label6.Size = new Size(205, 29);
            label6.TabIndex = 6;
            label6.Text = "01061085571:ت";
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1471, 1078);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Name = "Report";
            Text = "Report";
            Load += Report_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ToolTip toolTip1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label6;
        private Label label5;
    }
}