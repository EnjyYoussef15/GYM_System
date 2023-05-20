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
    public partial class CoachAddForm : Form
    {
        public CoachAddForm()
        {
            InitializeComponent();
        }

        private void btnCoachReset_Click(object sender, EventArgs e)
        {
            txtCoachClass.Text = string.Empty;
            txtCoachID.Text = string.Empty;
            txtCoachName.Text = string.Empty;
            txtCoachSalary.Text = string.Empty;
            txtCoachTrainee.Text = string.Empty;
            radMale.Checked = false;
            radFemale.Checked = false;
        }

        private void btnCoachAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCoachClass.Text)
                || (string.IsNullOrEmpty(txtCoachID.Text))
                || (string.IsNullOrEmpty(txtCoachName.Text))
                || (string.IsNullOrEmpty(txtCoachSalary.Text))
                || (string.IsNullOrEmpty(txtCoachTrainee.Text)))
            {

                lblErrCoach.Text = " You Must Enter All Information ";
                lblErrCoach.Visible = true;

            }
            else
            {
                txtCoachClass.Text = string.Empty;
                txtCoachID.Text = string.Empty;
                txtCoachName.Text = string.Empty;
                txtCoachSalary.Text = string.Empty;
                txtCoachTrainee.Text = string.Empty;
                radMale.Checked = false;
                radFemale.Checked = false;
                MessageBox.Show("Done");
            }

        }

        private void btnCoachBack_Click(object sender, EventArgs e)
        {
            Hide();

        }
    }
}
