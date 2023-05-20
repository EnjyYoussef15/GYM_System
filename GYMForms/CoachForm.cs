using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYMForms
{
    public partial class CoachForm : Form
    {
        public CoachForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCoachAdd_Click(object sender, EventArgs e)
        {

            Hide();

        }

        private void CoachForm_Load(object sender, EventArgs e)
        {

        }

        private void HireDateCoach_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCoachDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{txtCoachName.Text}, is Deleted");
        }

        private void btnCoachUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{txtCoachName.Text}, Data is Updated");
        }
    }
}
