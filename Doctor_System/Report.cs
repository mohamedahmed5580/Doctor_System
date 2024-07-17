using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
namespace Doctor_System
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void printer(Panel p1)
        {
            PrinterSettings p = new PrinterSettings();
            panel1 = p1;
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();

        }
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox2, "print");

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            printer(this.panel1);
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            Rectangle pageArea = e.PageBounds;

            // Create a bitmap of the panel
            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(bmp, new Rectangle(0, 0, panel1.Width, panel1.Height));

            // Draw the bitmap to the print document, scaling it to fit the page area
            e.Graphics.DrawImage(bmp, pageArea);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
