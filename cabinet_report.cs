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
namespace Lawyer_Sys
{
    public partial class cabinet_report : Form
    {
        PrintDocument printDocument = new PrintDocument();
        SqlConnection conn = new SqlConnection("server=MOHAMEDBEKO\\MSSQLSERVER01;database=Hospital;integrated security=true");
        public cabinet_report()
        {
            InitializeComponent();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ID as رقم_العملية, RevenueOfToday as الايراد_اليومي,cash as الكاش,vod_cash as فودافون_كاش,Expenses as المصروفات,Profit as الصافي,Date as التاريخ  FROM cabinet", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("server=MOHAMEDBEKO\\MSSQLSERVER01;database=Hospital;integrated security=true"))
            {
                conn.Open();
                string query = "SELECT SUM(Profit) FROM cabinet";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal totalProfit = (decimal)result;
                        lblTotalProfit.Text = $"اجمالي الدخل: {totalProfit:N2} جنيه مصري";
                    }
                    else
                    {
                        lblTotalProfit.Text = "اجمالي الدخل: 0.00";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from cabinet where ID='" + dataGridView1.CurrentRow.Cells[0].Value + "'", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("تم الحذف بنجاح");
        }

        private void cabinet_report_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
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
            int cellHeight = dataGridView1.RowTemplate.Height + 5;
            int totalWidth1 = dataGridView1.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            float scale = (float)e.MarginBounds.Width / Math.Max(totalWidth1 - 100, 500);
            e.Graphics.ScaleTransform(scale, scale);

            Pen pen = new Pen(Color.Black);

            // Print the title with larger font
            string title = "تقرير الخزنة";
            Font titleFont = new Font("Arial", 24, FontStyle.Bold); // Larger font size
            e.Graphics.DrawString(title, titleFont, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top);

            // Print additional data with larger font
            string additionalData = "Date: " + DateTime.Now.ToShortDateString();
            Font additionalDataFont = new Font("Arial", 14, FontStyle.Regular); // Larger font size
            e.Graphics.DrawString(additionalData, additionalDataFont, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + 40);

            y += 80; // Space for title and additional data

            // Print header for the first table with larger font
            Font headerFont = new Font("Arial", 14, FontStyle.Bold); // Larger font size for headers
            x = e.MarginBounds.Left;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                Rectangle rect = new Rectangle(x, y, col.Width, cellHeight);
                e.Graphics.FillRectangle(Brushes.LightGray, rect);
                e.Graphics.DrawRectangle(pen, rect);
                e.Graphics.DrawString(col.HeaderText, headerFont, Brushes.Black, rect); // Use larger font
                x += col.Width;
            }

            y += cellHeight;
            x = e.MarginBounds.Left;

            // Print rows for the first table with larger font
            Font cellFont = new Font("Arial", 12, FontStyle.Regular); // Larger font size for cells
            int rowsPerPage = e.MarginBounds.Height / cellHeight;
            int rowIndex = 0;
            while (rowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                if (y + cellHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true; // There are more pages to print
                    return;
                }

                foreach (DataGridViewCell cell in row.Cells)
                {
                    Rectangle rect = new Rectangle(x, y, cell.OwningColumn.Width, cellHeight);
                    e.Graphics.DrawRectangle(pen, rect);
                    e.Graphics.DrawString(cell.Value?.ToString(), cellFont, Brushes.Black, rect); // Use larger font
                    x += cell.OwningColumn.Width;
                }

                y += cellHeight;
                x = e.MarginBounds.Left;
                rowIndex++;

                if (rowIndex >= dataGridView1.Rows.Count)
                {
                    e.HasMorePages = false; // Last page
                }
            }

            y += margin; // Space between tables
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
