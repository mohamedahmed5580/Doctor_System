using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using Lawyer_Sys;
using System.Security.Cryptography;
using Hospital.Forms;
using DGVPrinterHelper;


namespace Doctor_System
{
    public partial class Patients : Form
    {
        // Connection string
        SqlConnection con = new SqlConnection("server=MOHAMEDBEKO\\MSSQLSERVER01;database=Hospital;integrated security=true");

        public Patients()
        {
            InitializeComponent();
            this.Load += new EventHandler(Patients_Load);
            LoadMainData();
            int maxPID = GetMaxPID();
            int newPID = maxPID + 1;
            idp.Text = newPID.ToString();



        }

        private void LoadMainData()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = new DataTable();
            dataGridView_show.DataSource = bs;
            dataGridView_show.DataSource = null;


            // Construct the SQL query with parameterized values
            string query = @"SELECT PID as رقم_المريض, Name AS الاسم, Phone AS الهاتف, Payments AS المبلغ_المدفوع, 
          Address AS العنوان, Type AS النوع, Type_Examination AS نوع_الكشف , Age AS العمر, Description AS ملاحظات, 
          date AS التاريخ FROM Patients";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView_show.DataSource = dt;
                }
            }


        }

        private void dataGridView_show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idp.Text = dataGridView_show.CurrentRow.Cells[0].Value.ToString();
                namep.Text = dataGridView_show.CurrentRow.Cells[1].Value.ToString();
                numberp.Text = dataGridView_show.CurrentRow.Cells[2].Value.ToString();
                nanumberp.Text = dataGridView_show.CurrentRow.Cells[3].Value.ToString();
                locationp.Text = dataGridView_show.CurrentRow.Cells[4].Value.ToString();
                description.Text = dataGridView_show.CurrentRow.Cells[8].Value.ToString();
                comboBox1.Text = dataGridView_show.CurrentRow.Cells[5].Value.ToString();
                comboBox2.Text = dataGridView_show.CurrentRow.Cells[6].Value.ToString();
                age.Text = dataGridView_show.CurrentRow.Cells[7].Value.ToString();
                dateTimePicker1.Text = dataGridView_show.CurrentRow.Cells[9].Value.ToString();
                Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            LoadMainData();
            int maxPID = GetMaxPID();
            int newPID = maxPID + 1;
            idp.Text = newPID.ToString();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {

            string query = @"UPDATE Patients 
                         SET Name = @Name, Payments = @Payments, Address = @Address, Type = @Type, Age = @Age,Type_Examination = @Type_Examination, Phone = @Phone, Description = @Description ,date=@date
                         WHERE PID = @PID";

            try
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@PID", int.Parse(idp.Text));
                    cmd.Parameters.AddWithValue("@Name", namep.Text);
                    cmd.Parameters.AddWithValue("@Payments", nanumberp.Text);
                    cmd.Parameters.AddWithValue("@Address", locationp.Text);
                    cmd.Parameters.AddWithValue("@Type", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@Type_Examination", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@Age", int.Parse(age.Text));
                    cmd.Parameters.AddWithValue("@Phone", numberp.Text);
                    cmd.Parameters.AddWithValue("@Description", description.Text);
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تم تعديل معلومات المريض");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Invalid input format: {ex.Message}");
            }
            finally
            {
                con.Close();
            }

            // After updating, refresh the DataGridView
            LoadMainData();
            ClearInputFields();
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO Patients (PID, Name, Phone, Payments, Address, Type, Age, Description,Type_Examination, date) 
                     VALUES (@PID, @Name, @Phone, @Payments, @Address, @Type, @Age, @Description,@Type_Examination, @Date)";
            try
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    try
                    {
                        // Set parameters from form controls or defaults
                        cmd.Parameters.AddWithValue("@PID", idp.Text);
                        cmd.Parameters.AddWithValue("@Name", namep.Text);
                        cmd.Parameters.AddWithValue("@Phone", numberp.Text);
                        cmd.Parameters.AddWithValue("@Payments", nanumberp.Text); // Assuming this is the payments field
                        cmd.Parameters.AddWithValue("@Address", locationp.Text);
                        cmd.Parameters.AddWithValue("@Type", comboBox1.Text);
                        cmd.Parameters.AddWithValue("@Age", int.Parse(age.Text));
                        cmd.Parameters.AddWithValue("@Description", description.Text);
                        cmd.Parameters.AddWithValue("@Type_Examination", comboBox2.Text);
                        // Check if a date is entered, if not, use today's date
                        if (dateTimePicker1.Value == null || dateTimePicker1.Value == DateTime.MinValue)
                        {
                            cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                        }
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"تم إضافة المريض بنجاح");

                        // Optionally, clear input fields after insertion
                        ClearInputFields();

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"المريض موجود مسبقا");
                    }

                }

                // Refresh the DataGridView after insertion
                con.Close();
                LoadMainData();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void locationp_TextChanged(object sender, EventArgs e)
        {

        }
        private int GetMaxPID()
        {
            int maxPID = 0;
            string query = "SELECT MAX(PID) FROM Patients";

            using (SqlConnection con = new SqlConnection("server=MOHAMEDBEKO\\MSSQLSERVER01;database=Hospital;integrated security=true"))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            maxPID = Convert.ToInt32(result);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
            return maxPID;
        }


        private void ClearInputFields()
        {
            // Clear all input fields after insertion
            idp.Text = "";
            namep.Text = "";
            numberp.Text = "";
            nanumberp.Text = "";
            locationp.Text = "";
            description.Text = "";
            comboBox1.SelectedIndex = 0;
            age.Text = "";
            int maxPID = GetMaxPID();
            int newPID = maxPID + 1;
            idp.Text = newPID.ToString();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete from Patients where PID='" + dataGridView_show.CurrentRow.Cells[0].Value + "'", con);
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

        private void idp_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (chouse.Text == "اسم المريض")
            {
                textBox1.PlaceholderText = "البحث بالاسم";
                string query = @"SELECT PID as رقم_المريض, Name AS الاسم, Phone AS الهاتف, Payments AS المبلغ_المدفوع, 
                     Address AS العنوان, Type AS النوع,Type_Examination AS نوع_الكشف , Age AS العمر, Description AS ملاحظات, 
                     date AS التاريخ FROM Patients WHERE Name = @Name  ";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", textBox1.Text);

                    SqlDataAdapter d = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    d.Fill(dt);
                    dataGridView_show.DataSource = dt;
                }
            }
            else if (chouse.Text == "رقم المريض")
            {
                textBox1.PlaceholderText = "البحث برقم الهاتف";
                string query = @"SELECT PID as رقم_المريض, Name AS الاسم, Phone AS الهاتف, Payments AS المبلغ_المدفوع, 
                     Address AS العنوان, Type AS النوع,Type_Examination AS نوع_الكشف , Age AS العمر, Description AS ملاحظات, 
                     date AS التاريخ FROM Patients WHERE Phone = @Name or  PID= @Name";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", textBox1.Text);

                    SqlDataAdapter d = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    d.Fill(dt);
                    dataGridView_show.DataSource = dt;
                }

            }
            else if (chouse.Text == "العنوان المريض")
            {
                textBox1.PlaceholderText = "البحث بالعنوان";
                string query = @"SELECT PID as رقم_المريض, Name AS الاسم, Phone AS الهاتف, Payments AS المبلغ_المدفوع, 
                     Address AS العنوان, Type AS النوع,Type_Examination AS نوع_الكشف , Age AS العمر, Description AS ملاحظات, 
                     date AS التاريخ FROM Patients WHERE Address = @Name  ";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", textBox1.Text);

                    SqlDataAdapter d = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    d.Fill(dt);
                    dataGridView_show.DataSource = dt;
                }
            }
            else if (chouse.Text == "العنوان")
            {
                textBox1.PlaceholderText = "البحث بالعنوان";
                string query = @"SELECT PID as رقم_المريض, Name AS الاسم, Phone AS الهاتف, Payments AS المبلغ_المدفوع, 
                     Address AS العنوان, Type AS النوع,Type_Examination AS نوع_الكشف , Age AS العمر, Description AS ملاحظات, 
                     date AS التاريخ FROM Patients WHERE Address = @Name  ";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", textBox1.Text);

                    SqlDataAdapter d = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    d.Fill(dt);
                    dataGridView_show.DataSource = dt;
                }
            }

            if (textBox1.Text == "")
            {
                LoadMainData();
                ClearInputFields();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void chouse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadMainData();
            ClearInputFields();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fy.Text) || string.IsNullOrWhiteSpace(fm.Text) || string.IsNullOrWhiteSpace(fd.Text) ||
                string.IsNullOrWhiteSpace(ty.Text) || string.IsNullOrWhiteSpace(tm.Text) || string.IsNullOrWhiteSpace(td.Text))
            {
                MessageBox.Show("Please fill in all date fields.");
                return;
            }
            else
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = new DataTable();
                dataGridView_show.DataSource = bs;

                // Construct date strings in the format SQL Server expects (YYYY-MM-DD)

                string fromDate = $"{fy.Text}-{fm.Text.PadLeft(2, '0')}-{fd.Text.PadLeft(2, '0')}";
                string toDate = $"{ty.Text}-{tm.Text.PadLeft(2, '0')}-{td.Text.PadLeft(2, '0')}";

                // Construct the SQL query with parameterized values
                string query = @"SELECT PID as رقم_المريض, Name AS الاسم, Phone AS الهاتف, Payments AS المبلغ_المدفوع, 
                     Address AS العنوان, Type AS النوع,Type_Examination AS نوع_الكشف , Age AS العمر, Description AS ملاحظات, 
                     date AS التاريخ FROM Patients WHERE date BETWEEN @FromDate AND @ToDate";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Add parameters with correct names and values
                    cmd.Parameters.AddWithValue("@FromDate", fromDate);
                    cmd.Parameters.AddWithValue("@ToDate", toDate);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView_show.DataSource = dt;
                    }
                }



            }

        }
        private int GetMaxWID()
        {
            int maxPID = 0;
            string query = "SELECT MAX(WID) FROM WaitingList";

            using (SqlConnection con = new SqlConnection("server=MOHAMEDBEKO\\MSSQLSERVER01;database=Hospital;integrated security=true"))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            maxPID = Convert.ToInt32(result);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"المريض موجود مسبقا");
                    }
                }
            }
            return maxPID;
        }
        private void waiting_btn_Click(object sender, EventArgs e)
        {


            try
            {
                int maxWID = GetMaxWID();
                int newWID = maxWID + 1;

                string query = @"insert into [dbo].[WaitingList](WID,PID) values (@WID,@PID)";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@PID", idp.Text);
                    cmd.Parameters.AddWithValue("@WID", newWID);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تم إضافة المريض بنجاح");

                    // Optionally, clear input fields after insertion
                    ClearInputFields();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show($"لقد تمت إضافة المريض بالفعل ");
            }
            con.Close();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenNewForm(new basic());
        }

        private void OpenNewForm(Form newForm)
        {
            // Subscribe to the new form's FormClosed event
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
            this.Hide(); // Optionally hide the current form until the new one is shown
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenNewForm(new basic());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void PrintReport()
        {
            try
            {
                DGVPrinter printer = new DGVPrinter();

                // Set the printer's properties
                printer.Title = "Hospital Report";
                printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "Hospital Management System";
                printer.FooterSpacing = 15;

                // Specify the DataGridView to print
                printer.PrintDataGridView(dataGridView_show);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}