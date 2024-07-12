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

namespace Doctor_System
{
    public partial class Reservations : Form
    {

        PrintDocument printDocument = new PrintDocument();


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
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            int margin = 40;
            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top + 50; // Adjust y for the title and additional data


            Pen pen = new Pen(Color.Black);

            // Print the title with larger font
            string title = "تقرير الطبي";
            Font titleFont = new Font("Arial", 24, FontStyle.Bold); // Larger font size
            e.Graphics.DrawString(title, titleFont, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top);

            // Print additional data with larger font

            string additionalData = "Date: " + DateTime.Now.ToShortDateString();
            Font additionalDataFont = new Font("Arial", 14, FontStyle.Regular); // Larger font size
            e.Graphics.DrawString(additionalData, additionalDataFont, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + 40);

            y += 80; // Space for title and additional data

            // Print additional data with larger font
            string addnameData = "الاسم: " + namepp.Text + ".";
            Font addnameDataFont = new Font("Arial", 15, FontStyle.Regular); // Larger font size
            e.Graphics.DrawString(addnameData, addnameDataFont, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + 80);



            // Print additional data with larger font
            string addPhoneData = "رقم المريض: " + idpp.Text + ".";
            Font addPhoneDataFont = new Font("Arial", 15, FontStyle.Regular); // Larger font size
            e.Graphics.DrawString(addPhoneData, addPhoneDataFont, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + 120);


            // Print additional data with larger font
            string addTypeData = "جنسية المريض: " + type.Text + ".";
            Font addTypeDataFont = new Font("Arial", 15, FontStyle.Regular); // Larger font size
            e.Graphics.DrawString(addTypeData, addTypeDataFont, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + 140);

            // Print additional data with larger font
            string addlocationData = "عنوان المريض: " + type.Text + ".";
            Font addlocationDataFont = new Font("Arial", 15, FontStyle.Regular); // Larger font size
            e.Graphics.DrawString(addlocationData, addlocationDataFont, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + 160);


            // Print additional data with larger font
            string adddateinData = "تاريخ المريض: " + datein.Text + ".";
            Font adddateinDataFont = new Font("Arial", 15, FontStyle.Regular); // Larger font size
            e.Graphics.DrawString(adddateinData, adddateinDataFont, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + 160);
            

                            // Print additional data with larger font
            string addtypeoflayData = "نوع المرض: " + typeoflay.Text + ".";
            Font addtypeoflayDataFont = new Font("Arial", 15, FontStyle.Regular); // Larger font size
            e.Graphics.DrawString(addtypeoflayData, addtypeoflayDataFont, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + 160);
            y += margin; // Space between tables
            /*this.Close();*/
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
    }
}