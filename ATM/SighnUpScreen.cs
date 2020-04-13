using System;
using System.Windows.Forms;

namespace ATM
{
    public partial class SighnUpScreen : Form
    {
        public SighnUpScreen()
        {
            InitializeComponent();
            utilitiesClass1.getfile();
            // Timer.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NametextBox2.Text == "")
            {
                MessageBox.Show("Please Provide Name in Name Box", "Error");
                return;
            }
            if (Fathertextbox.Text == "")
            {
                MessageBox.Show("Please Provide Father Name in fatherName Box", "Error");
                return;
            }
            if (PasswordtextBox4.Text == "")
            {
                MessageBox.Show("Please Provide Password in PasswordBox", "Error");
                return;
            }
            //Random r = new Random();
            //r.Next(10, 10000);
            Decimal tt = 0;
            decimal.TryParse(initialbalnce.Text, out tt);
            if (tt < 1000)
            {
                MessageBox.Show("Could Not Add Less Than Rs.1000", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //List<String> details = new List<string>();
            //details.Add(NametextBox2.Text+ ":");
            //details.Add(Fathertextbox.Text);
            //details.Add(AccounttextBox3.Text);
            //details.Add(PasswordtextBox4.Text);

            string data = NametextBox2.Text + ":";
            data += Fathertextbox.Text + ":";
            data += AccounttextBox3.Text + ":";
            data += PasswordtextBox4.Text + ":";
            data += initialbalnce.Text;
           
            utilitiesClass1.addtodb(data);
            Reset();
            disable();
            MessageBox.Show("Account Created Successfully!Please Rememeber Your Pin And Password.Please SignIN in  Login Screen.  ", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoginForm1 ds = new LoginForm1();
            ds.Show();
            this.Hide();



        }


        private void disable()
        {
            button1.Enabled = false;
            NametextBox2.Enabled = false;
            Fathertextbox.Enabled = false;
            AccounttextBox3.Enabled = false;
            PasswordtextBox4.Enabled = false;
            initialbalnce.Enabled = false;
        }

        private void Reset()
        {
            NametextBox2.Text = "";
            Fathertextbox.Text = "";
            AccounttextBox3.Text = "";
            PasswordtextBox4.Text = "";
            initialbalnce.Text = "";

        }


        private void AccounttextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void SighnUpScreen_Load(object sender, EventArgs e)
        {
            acountpingenerator();

        }

        private void acountpingenerator()
        {
            Random accontpin = new Random();

            AccounttextBox3.ReadOnly = true;

            AccounttextBox3.Text = accontpin.Next(10, 100000).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AccounttextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desighned And Devolped By Muhammad Farooq ,,, Group Of Companies ,Highly ENCRYPTED Saptware Dont ever Mess With it  .Feel free To contact US (+92)03202914433 ", "Spaarco ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Timer_Click(object sender, EventArgs e)
        {

        }

        private void initialbalnce_TextChanged(object sender, EventArgs e)
        {

        }

        private void initialbalnce_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Error only Write Numbers ", "error");
                e.Handled = true;

            }
        }


    }
}
