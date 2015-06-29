using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @lock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBox1.Visible = false;
        }
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        string pass = "arafat1234";
        private void btnSubmit_Click(object sender, EventArgs e)
        {
             if (txtPass.Text == "")
            {
                MessageBox.Show("You stupid,Go back to my computer.");
            }
            else
            {
                
                string j = txtPass.Text;
                if (pass == j)
                    Application.Exit();
                else
                    MessageBox.Show("You stupid,Go back to my computer.");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void changePassordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtNew.Text == "" && txtNew.Text == "")
            {
                MessageBox.Show("Please enter Old and New Password.");


            }
            else
            {
                if (pass == txtOld.Text)
                {
                    pass = txtNew.Text;
                    MessageBox.Show("Success.");
                    groupBox1.Visible = false;
                }
                else
                {
                    MessageBox.Show("Invalid Password!!");

                }


            }
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ali Ahmed \nBSc in CSSE\nAIUB\n01521497964");
        }

        private void enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (txtPass.Text == "")
                {
                    MessageBox.Show("You stupid,Go back to my computer.");
                }
                else
                {

                    string j = txtPass.Text;
                    if (pass == j)
                        Application.Exit();
                    else
                        MessageBox.Show("You stupid,Go back to my computer.");
                }

            }
        }

       

       
        
        
    }
}
