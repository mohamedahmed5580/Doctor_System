using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using Hospital.Forms;
using DGVPrinterHelper;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Doctor_System
{
    public partial class Reservations : Form
    {

        PrintDocument printDocument = new PrintDocument();
        SqlConnection con = new SqlConnection("server=MOHAMEDBEKO\\MSSQLSERVER01;database=Hospital;integrated security=true");


        public Reservations()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {


            printDocument.PrintPage += PrintDocument_PrintPage;
            PrintDialog printDialog = new PrintDialog
            {
                Document = printDocument
            };

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
            this.Hide();
        }

        private void OpenNewForm(Form newForm)
        {
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
            this.Hide();
            con.Close();

        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            int margin = 40;
            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top + 50; // Adjust y for the title and additional data

            Pen pen = new Pen(Color.Black);

            // Method to center text
            float CenterText(string text, Font font, Graphics graphics, Rectangle bounds)
            {
                SizeF textSize = graphics.MeasureString(text, font);
                return bounds.Left + (bounds.Width - textSize.Width) / 2;
            }

            // Method to right-align text
            float RightAlignText(string text, Font font, Graphics graphics, Rectangle bounds)
            {
                SizeF textSize = graphics.MeasureString(text, font);
                return bounds.Right - textSize.Width;

            }
            void DrawTextInRect(string text, Font font, Rectangle rect)
            {
                bool isArabic = text.Any(c => char.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.OtherLetter); // Check if any Arabic characters are present
                float textX = isArabic ? RightAlignText(text, font, e.Graphics, rect) : rect.Left; // Align right for Arabic, left otherwise
                e.Graphics.DrawString(text, font, Brushes.Black, textX, rect.Top);
            }

            // Method to calculate height based on text
            int CalculateTextHeight(string text, Font font, int maxWidth)
            {
                SizeF size = e.Graphics.MeasureString(text, font, maxWidth);
                return (int)Math.Ceiling(size.Height);
            }

            // Method to draw text inside a rectangle with dynamic height and language-based alignment


            // Print the title with larger font
            string title = "تقرير الطبي";
            Font titleFont = new Font("Arial", 24, FontStyle.Bold); // Larger font size
            float titleX = CenterText(title, titleFont, e.Graphics, e.MarginBounds);
            e.Graphics.DrawString(title, titleFont, Brushes.Black, titleX, e.MarginBounds.Top);

            // Print additional data with larger font
            string additionalData = "Date: " + DateTime.Now.ToShortDateString();
            Font additionalDataFont = new Font("Arial", 14, FontStyle.Regular); // Larger font size
            float additionalDataX = CenterText(additionalData, additionalDataFont, e.Graphics, e.MarginBounds);
            e.Graphics.DrawString(additionalData, additionalDataFont, Brushes.Black, additionalDataX, e.MarginBounds.Top + 40);

            y += 100; // Space for title and additional data

            // Print additional data blocks with larger font
            string[] dataBlocks = {
        "الاسم: " + namepp.Text,
        "رقم المريض: " + idpp.Text,
        "جنس المريض: " + type.Text,
        "عنوان المريض: " + location.Text,
        "تاريخ المريض: " + datein.Text,
        "نوع المرض: " + Disease.Text,
        "العلاجات: " + richTextBox1.Text
    };

            Font dataFont = new Font("Arial", 15, FontStyle.Regular); // Larger font size

            foreach (string data in dataBlocks)
            {
                int textHeight = CalculateTextHeight(data, dataFont, e.MarginBounds.Width);
                Rectangle rect = new Rectangle(x, y, e.MarginBounds.Width, textHeight);
                e.Graphics.DrawRectangle(pen, rect);
                DrawTextInRect(data, dataFont, rect); // Align based on content language
                y += textHeight + 10;
            }

            y += margin; // Space between sections

            this.Hide();

        }



        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reservations_Load(object sender, EventArgs e)
        {

        }

        private void typeoflay_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                string name = namepp.Text; // Assuming you have a TextBox for Name
                int pid = int.Parse(idpp.Text); // Assuming you have a TextBox for PID
                string description = richTextBox1.Text; // Assuming you have a TextBox for Description
                int quantityy = int.Parse(quantity.Text); // Assuming you have a TextBox for Quantity
                string Diseases = Disease.Text; // Assuming you have a TextBox for PatientPID


                string query = @"INSERT INTO prescription ( Name, PID, Description, Quantity, Disease)
                     VALUES (@Name, @PID, @Description, @Quantity, @Disease)";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@PID", pid);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@Quantity", quantityy);
                    cmd.Parameters.AddWithValue("@Disease", Diseases);
                    MessageBox.Show($"تمت اضافة الكشف ينجاح");
                    cmd.ExecuteNonQuery();

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                con.Close();
            }

        }

        private void namepp_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}