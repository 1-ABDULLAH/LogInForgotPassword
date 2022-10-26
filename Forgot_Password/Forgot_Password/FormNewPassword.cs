using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forgot_Password
{
    public partial class FormNewPassword : Form
    {
        public FormNewPassword()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if(textBoxNew.Text.Trim()== textBoxConfirm.Text.Trim())
            {

                Form1.Password=textBoxConfirm.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Password not Matched.","New!= Confirm",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCNIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDOB_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
