using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Login_Click(object sender, EventArgs e)
        {
            MainForm mainPage = new MainForm();
          
            if (string.IsNullOrEmpty(txtLoginUseName.Text) || string.IsNullOrEmpty(txtLoginPass.Text))
            {
                labelWrongUserNameOrPassowrd.Text = "Woring Passoword or User";
               
            }
            else
            {
                mainPage.Show();
                Hide();    

            }
        }

        private void labelWrongUserNameOrPassowrd_Click(object sender, EventArgs e)
        {

        }
    }
}
