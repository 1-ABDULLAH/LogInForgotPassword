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
    public partial class FormForgotPassword : Form
    {
        public FormForgotPassword()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        { if (textBoxCNIC.Text.Trim() == "11122233344"
                        )
            {
                this.Close();
                FormNewPassword fnp = new FormNewPassword();
                fnp.ShowDialog();

            }
            else
            {
                MessageBox.Show("Invalid CNIC !",
                    "Failed Log In",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
            }

        }

        private void dateTimePickerDOB_ValueChanged(object sender, EventArgs e)
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

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
