using Hospital.Forms;

namespace Hospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (name.Text == "admin" && password.Text == "123456789")
            {
                MessageBox.Show("تم  تسجيل الدخول بنجاح");
                basic to_basic_Form = new basic(); // Assuming Form2 is the other form

                this.Hide();
                to_basic_Form.Show();
                to_basic_Form.FormClosed += (s, args) => this.Show();

            }
            else
            {
                MessageBox.Show("خطأ");

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
