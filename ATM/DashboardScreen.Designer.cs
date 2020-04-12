namespace ATM
{
    partial class DashboardScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardScreen));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ATM = new System.Windows.Forms.Label();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.Depositbutton1 = new System.Windows.Forms.Button();
            this.Transaction = new System.Windows.Forms.Button();
            this.Checkbalncebutto = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TransactiotextBox2 = new System.Windows.Forms.TextBox();
            this.tt = new System.Windows.Forms.Label();
            this.initialtotalbalance = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(931, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.ATM);
            this.panel1.Controls.Add(this.Titlelabel);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 75);
            this.panel1.TabIndex = 1;
            // 
            // ATM
            // 
            this.ATM.AutoSize = true;
            this.ATM.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ATM.Location = new System.Drawing.Point(51, 18);
            this.ATM.Name = "ATM";
            this.ATM.Size = new System.Drawing.Size(100, 42);
            this.ATM.TabIndex = 1;
            this.ATM.Text = "ATM";
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelabel.Location = new System.Drawing.Point(376, 18);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(0, 24);
            this.Titlelabel.TabIndex = 0;
            // 
            // Depositbutton1
            // 
            this.Depositbutton1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Depositbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Depositbutton1.Image = ((System.Drawing.Image)(resources.GetObject("Depositbutton1.Image")));
            this.Depositbutton1.Location = new System.Drawing.Point(12, 108);
            this.Depositbutton1.Name = "Depositbutton1";
            this.Depositbutton1.Size = new System.Drawing.Size(169, 60);
            this.Depositbutton1.TabIndex = 2;
            this.Depositbutton1.Text = "Deposit";
            this.Depositbutton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Depositbutton1.UseVisualStyleBackColor = false;
            this.Depositbutton1.Click += new System.EventHandler(this.Depositbutton1_Click);
            // 
            // Transaction
            // 
            this.Transaction.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Transaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transaction.Image = ((System.Drawing.Image)(resources.GetObject("Transaction.Image")));
            this.Transaction.Location = new System.Drawing.Point(12, 212);
            this.Transaction.Name = "Transaction";
            this.Transaction.Size = new System.Drawing.Size(169, 60);
            this.Transaction.TabIndex = 2;
            this.Transaction.Text = "Transaction";
            this.Transaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Transaction.UseVisualStyleBackColor = false;
            this.Transaction.Click += new System.EventHandler(this.Transaction_Click);
            // 
            // Checkbalncebutto
            // 
            this.Checkbalncebutto.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Checkbalncebutto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkbalncebutto.Image = ((System.Drawing.Image)(resources.GetObject("Checkbalncebutto.Image")));
            this.Checkbalncebutto.Location = new System.Drawing.Point(498, 108);
            this.Checkbalncebutto.Name = "Checkbalncebutto";
            this.Checkbalncebutto.Size = new System.Drawing.Size(169, 60);
            this.Checkbalncebutto.TabIndex = 2;
            this.Checkbalncebutto.Text = "Check Balnce";
            this.Checkbalncebutto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Checkbalncebutto.UseVisualStyleBackColor = false;
            this.Checkbalncebutto.Click += new System.EventHandler(this.Checkbalncebutto_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SeaShell;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(498, 212);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 60);
            this.button4.TabIndex = 2;
            this.button4.Text = "Close";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 6;
            // 
            // TransactiotextBox2
            // 
            this.TransactiotextBox2.Location = new System.Drawing.Point(210, 233);
            this.TransactiotextBox2.Name = "TransactiotextBox2";
            this.TransactiotextBox2.Size = new System.Drawing.Size(166, 20);
            this.TransactiotextBox2.TabIndex = 12;
            this.TransactiotextBox2.TextChanged += new System.EventHandler(this.TransactiotextBox2_TextChanged);
            this.TransactiotextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TransactiotextBox2_KeyPress);
            // 
            // tt
            // 
            this.tt.AutoSize = true;
            this.tt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt.Location = new System.Drawing.Point(306, 322);
            this.tt.Name = "tt";
            this.tt.Size = new System.Drawing.Size(164, 25);
            this.tt.TabIndex = 13;
            this.tt.Text = "Total Balance ";
            // 
            // initialtotalbalance
            // 
            this.initialtotalbalance.AutoSize = true;
            this.initialtotalbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialtotalbalance.Location = new System.Drawing.Point(514, 322);
            this.initialtotalbalance.Name = "initialtotalbalance";
            this.initialtotalbalance.Size = new System.Drawing.Size(25, 25);
            this.initialtotalbalance.TabIndex = 14;
            this.initialtotalbalance.Text = "0";
            // 
            // DashboardScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(931, 376);
            this.Controls.Add(this.initialtotalbalance);
            this.Controls.Add(this.tt);
            this.Controls.Add(this.TransactiotextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Checkbalncebutto);
            this.Controls.Add(this.Transaction);
            this.Controls.Add(this.Depositbutton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "DashboardScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardScreen";
            this.Load += new System.EventHandler(this.DashboardScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.Button Depositbutton1;
        private System.Windows.Forms.Button Transaction;
        private System.Windows.Forms.Button Checkbalncebutto;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TransactiotextBox2;
        private System.Windows.Forms.Label ATM;
        private System.Windows.Forms.Label tt;
        private System.Windows.Forms.Label initialtotalbalance;
    }
}