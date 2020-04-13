using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ATM
{
    public partial class DashboardScreen : Form
    {
        public decimal blnce = 0;
        public string getadmin { get; set; }
        public DashboardScreen()
        {
            InitializeComponent();
            // string pk1 = utilitiesClass1.getdata();
            //MessageBox.Show("Testname",pk1);


            // string pk2 = ;
            // string dd = "E:\\vswork\\ATM\\"+pk1+".txt";
            //   FileStream sww = new FileStream("E:\\vswork\\ATM\\"+ pk1 + ".txt",FileMode.Create);
            // metadata = Path.Combine(dd, pk2);

            //string er = getdata();
            // totalbalnce.Text = er;
            ////  metadata = FileMode.Create;
            //metadata= @"E:\vswork\ATM\"+pk1+".txt";
            //  if (!(File.Exists(metadata)))
            //  {
            //      File.Create(metadata).Close();
            //  }
        }
        public DashboardScreen(string admn)
        {
            InitializeComponent();

            getadmin = admn;
        }

        private void DashboardScreen_Load(object sender, EventArgs e)
        {
            hidee();
            string pk = utilitiesClass1.getdata();
            string pl = utilitiesClass1.loadbalnce;
            //MessageBox.Show("Test" + pk) ;
            Titlelabel.Text = "Welcome" + " " + pk + "!";
            initialtotalbalance.Text = pl;
            Depositbutton1.Enabled = false;

            if (getadmin == "admin")
            {
                Checkbalncebutto.Show();
            }
            else
            {
                Checkbalncebutto.Hide();
            }


        }

        private void hidee()
        {
            TransactiotextBox2.Hide();
            Depositbutton1.Hide();
            Transaction.Hide();
            button1.Hide();
            textBox1.Hide();
            label5.Hide();
            richTextBox1.Hide();
            richTextBox2.Hide();
            transactionlabel.Hide();
            label2.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
        }
        private void showw()
        {
            Depositbutton1.Show();
            textBox1.Show();
            button1.Show();
            Transaction.Hide();
            TransactiotextBox2.Hide();
            richTextBox1.Show();
            label5.Hide();
            transactionlabel.Hide();
            label2.Show();
            richTextBox2.Hide();
            button6.Hide();
            button7.Hide();
            button8.Show();
            button9.Show();
        }
        private void show2()
        {
            Transaction.Show();
            TransactiotextBox2.Show();
            button1.Hide();
            Depositbutton1.Hide();
            textBox1.Hide();
            richTextBox2.Show();
            label5.Show();
            transactionlabel.Show();
            label2.Hide();
            richTextBox1.Hide();
            button6.Show();
            button7.Show();
            button8.Hide();
            button9.Hide();
        }

        public decimal balance(string data)
        {
            //data = null;
            decimal data2 = 0;

            //   textBox1.Text = data;
            decimal.TryParse(data, out data2);
            return data2;
        }
        public decimal lowbalance = 500;
        public decimal highbalance = 50000;
        public decimal balance1 = 0;
        private void Depositbutton1_Click(object sender, EventArgs e)
        {

            //StreamWriter sw = new StreamWriter(path);
            //sw.Write(balance1+":");
            //sw.Close();   
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Error Please Write  your Rupees/dollars in deposit Box ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            else if (lowbalance > Convert.ToDecimal(textBox1.Text))
            {
                MessageBox.Show("Error Cannot Deposit Less Than Rs.500 in  deposit Box ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            else if (highbalance < Convert.ToDecimal(textBox1.Text))
            {
                MessageBox.Show("Error Cannot Deposit More Than Rs.50000 in Deposit Box  ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            //else if (button1.Handle==true)
            //{
            //    MessageBox.Show("Error First Add The balance By Clicking The Add ","Error");
            //    return;
            //}
            else
            {


                deposit();
                MessageBox.Show("Balance Has Been Deposited ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //StreamReader pop = new StreamReader(path); 
                //    string data = sew.ToString();
                //string[] daaa = data.Split(':');
                //string writer;
                //int i = 0;
                //sew.Write(ko);
                //sew.Write(textBox1.Text);
                richTextBox1.Text += textBox1.Text +"Deposited Balance \t " + DateTime.Now.ToString() + Environment.NewLine;
                return;
            }


            //for (int i = 0; i < daaa.Length - 1; i++)
            //{

            //   daaa[i]=ko   ;
            //   daaa[i + 1]= textBox1.Text ;
            //    writer = daaa[i];
            //        writer += daaa[i + 1];
            //    File.WriteAllLines(path,  daaa);
            // //   sew.Write(writer);
            //    }

            // textBox1.Text = utilitiesClass1.balnce;
        }
        public static bool check;
        private void deposit()
        {
            var builder = new StringBuilder();
            string ko = utilitiesClass1.dataa;
            string[] wordd;
            //   int i = 0;

            wordd = File.ReadAllLines(utilitiesClass1.data);
            var lines = new List<string>();


            //string po= File.OpenWrite(path).ToString();
            foreach (string word in wordd)
            {
                string[] line = word.Split(':');

                if (line[2] == utilitiesClass1.dataa)
                {

                    line[4] = initialtotalbalance.Text;

                    //  builder.Replace(line[4], initialtotalbalance.Text);

                    //File.WriteAllText(utilitiesClass1.data,word +":");

                    // File.AppendAllText(utilitiesClass1.data,line+":");
                }
                // line[4].Replace(line[4], initialtotalbalance.Text);
                lines.Add(string.Join(":", line));

            }
            File.WriteAllLines(utilitiesClass1.data, lines);

        }




        public static bool x;
        public static bool xx = false;
        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Error Please Write  your Rupees/dollars in deposit Box ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                x = true;
                return;
            }
            else if (lowbalance > Convert.ToDecimal(textBox1.Text))
            {
                MessageBox.Show("Error Cannot Deposit Less Than Rs.500 in  deposit Box ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                x = true;
                return;
            }
            else if (highbalance < Convert.ToDecimal(textBox1.Text))
            {
                MessageBox.Show("Error Cannot Deposit More Than Rs.50000 in Deposit Box  ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                x = true;
                return;
            }


            else
            {
                x = false;

                decimal get = balance(initialtotalbalance.Text);
                if (xx == false)
                {
                    blnce += balance(textBox1.Text);
                    blnce += balance(initialtotalbalance.Text);
                    Resett();
                    MessageBox.Show("Your Balance Has Been Added Now Deposit The Balance By CLicking The Deposit Button ", "Deposit It !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //balance1 += blnce;
                    initialtotalbalance.Text = blnce.ToString();
                    Depositbutton1.Enabled = true;
                    xx = true;
                    return;
                }
                else
                {
                    blnce += balance(textBox1.Text);
                    MessageBox.Show("Your Balance Has Been Added Now Deposit The Balance By CLicking The Deposit Button ", "Deposit It !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Depositbutton1.Focus();
                    initialtotalbalance.Text = blnce.ToString();
                    Depositbutton1.Enabled = true;
                }
                //deposit();


            }
            if (x == false)
            {

            }
        }

        private void Resett()
        {
            initialtotalbalance.Text = "";
        }

        private void TotaltextBox2_TextChanged(object sender, EventArgs e)
        {

            //button1_Click(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DepositgroupBox1_Enter(object sender, EventArgs e)
        {

        }
        public string getdta;
        public decimal ttt = 0;
        private void Transaction_Click(object sender, EventArgs e)
        {
            ttt = balance(initialtotalbalance.Text);
            if (TransactiotextBox2.Text.Trim() == "")
            {
                MessageBox.Show("Error Please Write  your Rupees/dollars in Trasaction Box ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            else if (lowbalance > Convert.ToDecimal(TransactiotextBox2.Text))
            {
                MessageBox.Show("Cannot Transact less Than Rs.500  ", "Error");
                return;
            }
            else if (highbalance < Convert.ToDecimal(TransactiotextBox2.Text))
            {
                MessageBox.Show("Error Cannot Transact More Than Rs.50000 in Transaction Box  ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }


            else if (ttt < balance(TransactiotextBox2.Text))
            {
                MessageBox.Show("Error! Not Enough Balance !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                Decimal HH = balance(initialtotalbalance.Text);

                while (!(HH < lowbalance))
                {



                    Transactionn();
              
                    MessageBox.Show("Congratulation Amount of " + TransactiotextBox2.Text + " has been transacted .Please Remove Your Card Safely!! . Your Total Balance is " + initialtotalbalance.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    richTextBox2.Text += TransactiotextBox2.Text + "transacted Balance \t " + DateTime.Now.ToString() + Environment.NewLine;
                    //balance1 -= Convert.ToDecimal( TransactiotextBox2.Text);
                    return;
                    // MessageBox.Show("Test");
                }
                MessageBox.Show("Could not Transact. Balance is Less Than 500 please Deposit Some Amount ", "Error", MessageBoxButtons.OK);
            }
        }
        public decimal trnsctblance = 0;
        private void Transactionn()
        {
            //  blnce -= balance(TransactiotextBox2.Text);
            string[] wordss = File.ReadAllLines(utilitiesClass1.data);
            var listt = new List<string>();
            foreach (var words in wordss)
            {
                string[] line = words.Split(':');
                if (line[2] == utilitiesClass1.dataa)
                {
                    trnsctblance = balance(line[4]);

                    trnsctblance -= balance(TransactiotextBox2.Text);

                    initialtotalbalance.Text = trnsctblance.ToString();
                    line[4] = trnsctblance.ToString();
                }
                listt.Add(string.Join(":", line));
                File.WriteAllLines(utilitiesClass1.data, listt);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Do You Really Want To Close It !", "Close", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (rs == DialogResult.OK)
            {
                this.Close();

            }


        }

        private void Checkbalncebutto_Click(object sender, EventArgs e)
        {
            Process.Start(utilitiesClass1.data);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Error only Write Numbers ", "error");
                e.Handled = true;

            }
        }

        private void TransactiotextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TransactiotextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Error only Write Numbers ", "error");
                e.Handled = true;

            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desighned And Devolped By Muhammad Farooq,, ,Highly ENCRYPTED Saptware Dont ever Mess With it  .Feel free To contact US (+92)03202914433 ", "Spaarco ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panel2.Width==120)
            {
                panel2.Width = 10;
                return;
            }
            else
            {
                panel2.Width = 120;
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showw();
            label4.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            show2();
            label4.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            utilitiesClass1.addtodb2(richTextBox2.Text);
            Process.Start(utilitiesClass1.data11);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            utilitiesClass1.addtodb2(richTextBox1.Text);

            Process.Start(utilitiesClass1.data11);
        }

        //private bool check(string po)
        //{
        //    string []data = po.Split(':');
        //    for (int i = 0; i < data.Length-1; i++)
        //    {
        //        if (data[i+1]==po)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
    }
}
