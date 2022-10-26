namespace Forgot_Password
{
    public partial class Form1 : Form
    {

        public static string Username,Password;
        public Form1()
        {
            InitializeComponent();
            Username = "Abdullah Tanrýverdi";
            Password = "Abdullah Tanrýverdi";


        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labelFP_Click(object sender, EventArgs e)
        {
            FormForgotPassword ffp=new FormForgotPassword();
            ffp.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text.Trim()== Username
                &&
                textBoxPassword.Text.Trim() == Password)
            {

                MessageBox.Show("Hello", "Log In",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!", "Failed Log In",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}