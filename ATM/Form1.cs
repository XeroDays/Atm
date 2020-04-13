using System;
using System.Windows.Forms;

namespace ATM
{
    public partial class LoginForm1 : Form
    {
        public LoginForm1()
        {
            InitializeComponent();
        }

        private void LoginForm1_Load(object sender, EventArgs e)
        {
            button1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SighnUpScreen dd = new SighnUpScreen();
            this.Hide();
            dd.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loginlogic();
        }

        private void Loginlogic()
        {
            DashboardScreen db = new DashboardScreen();
            if (utilitiesClass1.readtext(AccountpintextBox1.Text, passwordtextbox.Text) == true)
            {
                MessageBox.Show("Logged in succed", "Suucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                db.Show();

                return;

            }
            else if (AccountpintextBox1.Text == "458" && passwordtextbox.Text == "config")
            {
                MessageBox.Show("Welcome Admin");
                this.Hide();
                DashboardScreen db2 = new DashboardScreen("admin");
                db2.Show();
                return;
            }
            else
            {
                MessageBox.Show("Login failed ,If you Havent Created Account Yet Create it By Clicking On Sign up Button OR IF YOU HAVE fORGETTEN YOUR CLICK ON FORGET BUTTON!! ", "Login Failed", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);

                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Do You Really Want To Close It !", "Close", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (rs == DialogResult.OK)
            {
                this.Close();

            }
        }

        private void AccountpintextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void AccountpintextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Error only Write Numbers ", "error");
                e.Handled = true;

            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desighned And Devolped By Muhammad Farooq  ,Muhammad Ali,Adil Afridi ,Highly ENCRYPTED Saptware Dont ever Mess With it  .Feel free To contact US (+92)03202914433 ", "Spaarco ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Contact the Admin of Bank Farooq >> 03202914433 with following detail Your name Cnic and Father Name ");
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                button1_Click(sender, e);
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

            

        }
    }
}
