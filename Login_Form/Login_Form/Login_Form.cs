namespace Login_Form
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e) // photo for username
        {

        }

        private void txtUsername_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e) // photo for password
        {

        }


        private void btnLogin_Click_1(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtUsername.Text) || (string.IsNullOrEmpty(txtPassword.Text)))
            {

                lblErrorMassege.Text = " You Must Provide Username Or Password ";
                lblErrorMassege.Visible = true;

            }
            else
            {


            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPassword.Text = string.Empty;
            txtUsername.Text = string.Empty;
        }


    }
}