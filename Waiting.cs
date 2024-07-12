using Hospital.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DGVPrinterHelper.DGVPrinter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Doctor_System
{
    public partial class Waiting : Form
    {
        SqlConnection con = new SqlConnection("server=MOHAMEDBEKO\\MSSQLSERVER01;database=Hospital;integrated security=true");

        public Waiting()
        {
            InitializeComponent();
           
        }

        private void Waiting_Load(object sender, EventArgs e)
        {
            LoadMainData();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView_show2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete from WaitingList where WID='" + dataGridView_show2.CurrentRow.Cells[0].Value + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم الحذف بنجاح");
                LoadMainData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadMainData()
        {

            // Construct the SQL query with parameterized values
            string query = @"SELECT WID as رقم_الانتظار,Patients.PID as رقم_المريض, Name AS الاسم, Phone AS الهاتف, Payments AS المبلغ_المدفوع, 
                     Address AS العنوان, Type AS النوع,Type_Examination AS نوع_الكشف , Age AS العمر, Description AS ملاحظات, 
                     date AS التاريخ FROM [Patients] ,[WaitingList] where WaitingList.PID = Patients.PID ";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView_show2.DataSource = dt;
                }
            }

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenNewForm(new basic());
        }

        private void OpenNewForm(Form newForm)
        {
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
            this.Hide(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reservations reservations = new Reservations();
            reservations.idpp.Text = dataGridView_show2.CurrentRow.Cells[1].Value.ToString();
            reservations.namepp.Text = dataGridView_show2.CurrentRow.Cells[2].Value.ToString();
            reservations.type.Text = dataGridView_show2.CurrentRow.Cells[7].Value.ToString();
            reservations.datein.Text = dataGridView_show2.CurrentRow.Cells[10].Value.ToString();
            reservations.location.Text = dataGridView_show2.CurrentRow.Cells[5].Value.ToString();
            reservations.Show();    
        }
    }
}
