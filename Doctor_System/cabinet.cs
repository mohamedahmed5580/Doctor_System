using Hospital.Forms;
using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lawyer_Sys
{
    public partial class cabinet : Form
    {
        SqlConnection con = new SqlConnection("server=MOHAMEDBEKO\\MSSQLSERVER01;database=Lawyer_System1;integrated security=true");
        public cabinet()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cabinet_report a = new cabinet_report();
            a.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Adding_revenue w = new Adding_revenue();
            w.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cabinet_date_search c = new cabinet_date_search();
            c.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
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

        private void cabinet_Load(object sender, EventArgs e)
        {

        }
    }
}
