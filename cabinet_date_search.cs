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
namespace Lawyer_Sys
{
    public partial class cabinet_date_search : Form
    {
        PrintDocument printDocument = new PrintDocument();
        SqlConnection conn = new SqlConnection("server=MOHAMEDBEKO\\MSSQLSERVER01;database=Hospital;integrated security=true");
        public cabinet_date_search()
        {
            InitializeComponent();
        }

        private void cabinet_date_search_Load(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value.Date;
            DateTime endDate = dateTimePicker2.Value.Date;

            DataTable result = null;

            if (startDate == endDate)
            {
                result = GetCabinetDataBySingleDate(startDate);
            }
            else
            {
                result = GetCabinetDataByDateRange(startDate, endDate);
            }

            if (result != null && result.Rows.Count > 0)
            {
                dataGridView1.DataSource = result;
            }
            else
            {
                MessageBox.Show("لا توجد بيانات في هذه الفترة");
            }

        }
        private DataTable GetCabinetDataByDateRange(DateTime startDate, DateTime endDate)
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT ID as رقم_العملية, RevenueOfToday as الايراد_اليومي,cash as الكاش,vod_cash as فودافون_كاش,Expenses as المصروفات,Profit as الصافي,Date as التاريخ  FROM cabinet " +
                           "WHERE Date BETWEEN @StartDate AND @EndDate;";

            using (SqlConnection connection = new SqlConnection("server=MOHAMEDBEKO\\MSSQLSERVER01;database=Hospital;integrated security=true"))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@EndDate", endDate);

                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }

            return dataTable;
        }

        private DataTable GetCabinetDataBySingleDate(DateTime date)
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT ID as رقم_العملية, RevenueOfToday as الايراد_اليومي,cash as الكاش,vod_cash as فودافون_كاش,Expenses as المصروفات,Profit as الصافي,Date as التاريخ  FROM cabinet " +
                           "WHERE Date = @Date;";

            using (SqlConnection connection = new SqlConnection("server=MOHAMEDBEKO\\MSSQLSERVER01;database=Hospital;integrated security=true"))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Date", date);



                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);




            }

            return dataTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value.Date;
            DateTime endDate = dateTimePicker2.Value.Date;

            decimal sumProfit = GetSumOfProfitByDateRange(startDate, endDate);
            lblTotalProfit.Text = $"اجمالي الصافي: {sumProfit:N} جنيه مصري";
        }
        private decimal GetSumOfProfitByDateRange(DateTime startDate, DateTime endDate)
        {
            decimal sumProfit = 0;

            string query = "SELECT SUM(Profit) " +
                           "FROM cabinet " +
                           "WHERE Date BETWEEN @StartDate AND @EndDate;";

            using (SqlConnection connection = new SqlConnection("server=MOHAMEDBEKO\\MSSQLSERVER01;database=Hospital;integrated security=true"))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@EndDate", endDate);



                connection.Open();
                var result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    sumProfit = Convert.ToDecimal(result);
                }
            }

            return sumProfit;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenNewFormAndCloseCurrent(new basic());
        }

        private void OpenNewFormAndCloseCurrent(Form newForm)
        {
            // Subscribe to the new form's FormClosed event
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
            this.Hide(); // Optionally hide the current form until the new one is shown
        }
        private void button4_Click(object sender, EventArgs e)
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
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
