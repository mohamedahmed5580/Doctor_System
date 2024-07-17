using System;
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
using System.Xml.Linq;

namespace Doctor_System
{
    public partial class editPrescription : Form
    {
        SqlConnection con = new SqlConnection("server=MOHAMEDBEKO\\MSSQLSERVER01;database=Hospital;integrated security=true");

        public editPrescription()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = namepp.Text; // Assuming you have a TextBox for Name
                int pid = int.Parse(idpp.Text); // Assuming you have a TextBox for PID
                string description = richTextBox1.Text; // Assuming you have a TextBox for Description
                int quantityy = int.Parse(quantity.Text); // Assuming you have a TextBox for Quantity
                string diseases = Disease.Text; // Assuming you have a TextBox for Disease
                int preid = int.Parse(preIdTextBox.Text); // Assuming you have a TextBox for PREID

                string query = @"UPDATE prescription 
                     SET Name = @Name, PID = @PID, Description = @Description, Quantity = @Quantity, Disease = @Disease
                     WHERE PREID = @PREID";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@PID", pid);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@Quantity", quantityy);
                    cmd.Parameters.AddWithValue("@Disease", diseases);
                    cmd.Parameters.AddWithValue("@PREID", preid);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تم تحديث معلومات المريض بنجاح");
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

          this.Hide();

        }
             
        private void OpenNewForm(Form newForm)
        {
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
            this.Hide();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
            {

            }

        private void editPrescription_Load(object sender, EventArgs e)
        {

           
        }
    }
}
