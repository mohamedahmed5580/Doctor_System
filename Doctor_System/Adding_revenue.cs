using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lawyer_Sys
{
    public partial class Adding_revenue : Form
    {
        SqlConnection con = new SqlConnection("server=MOHAMEDBEKO\\MSSQLSERVER01;database=Hospital;integrated security=true");
        public Adding_revenue()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = con;

                if (!string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text))
                {
                    query = "INSERT INTO cabinet (RevenueOfToday, Expenses, cash, vod_cash) VALUES (@RevenueOfToday, @Expenses, @cash, @vod_cash)";
                    cmd.Parameters.AddWithValue("@RevenueOfToday", decimal.Parse(textBox1.Text));
                    cmd.Parameters.AddWithValue("@Expenses", decimal.Parse(textBox2.Text));
                    cmd.Parameters.AddWithValue("@cash", decimal.Parse(textBox3.Text));
                    cmd.Parameters.AddWithValue("@vod_cash", decimal.Parse(textBox4.Text));
                }
                else if(string.IsNullOrEmpty(textBox2.Text) && string.IsNullOrEmpty(textBox3.Text) && string.IsNullOrEmpty(textBox4.Text))
                {
                    query = "INSERT INTO cabinet (RevenueOfToday) VALUES (@RevenueOfToday)";
                    cmd.Parameters.AddWithValue("@RevenueOfToday", decimal.Parse(textBox1.Text));

                }
                else if (string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox3.Text))
                {
                    query = "INSERT INTO cabinet (RevenueOfToday, cash, vod_cash) VALUES (@RevenueOfToday, @cash, @vod_cash)";
                    cmd.Parameters.AddWithValue("@RevenueOfToday", decimal.Parse(textBox1.Text));
                    cmd.Parameters.AddWithValue("@cash", decimal.Parse(textBox3.Text));
                    cmd.Parameters.AddWithValue("@vod_cash", decimal.Parse(textBox4.Text));
                }
                else
                {
                    query = "INSERT INTO cabinet (RevenueOfToday, Expenses) VALUES (@RevenueOfToday, @Expenses)";
                    cmd.Parameters.AddWithValue("@RevenueOfToday", decimal.Parse(textBox1.Text));
                    cmd.Parameters.AddWithValue("@Expenses", decimal.Parse(textBox2.Text));
                }

                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("تمت عملية الاضافة بنجاح");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Adding_revenue_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
