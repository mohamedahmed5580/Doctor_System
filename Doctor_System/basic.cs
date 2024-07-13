using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Lawyer_Sys;
using Doctor_System;

namespace Hospital.Forms
{
    public partial class basic : Form
    {
        public basic()
        {
            InitializeComponent();

        }

        private void basic_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenNewFormAndCloseCurrent(new cabinet());
            /*            cabinet q = new cabinet();
                        q.Show();*/
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenNewFormAndCloseCurrent(new Patients());
            /*            Patients q = new Patients();
            q.Show();*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
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
            OpenNewFormAndCloseCurrent(new Waiting());
            /*
                        Waiting waiting = new Waiting();
                        waiting.Show();*/


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void الةحاسبةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\System32\\calc.exe");
        }

        private void المبرجينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            programers p = new programers();
            p.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}