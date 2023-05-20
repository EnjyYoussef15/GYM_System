using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness
{
    public partial class TraineeForm : Form
    {
        public TraineeForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Hide();
        }

        private void TraineeForm_Load(object sender, EventArgs e)
        {

        }

        private void btnTraineeReset_Click(object sender, EventArgs e)
        {
            txtTraineeID.Text = "";
            txtTraineeName.Text = "";
            txtTraineeAge.Text = "";
            txtTraineeClass.Text = "";
            txtTraineePhone.Text = "";
            txtTraineeSubscriptionFee.Text = "";
            txtDurationUpDown.Value = 0;

        }

        private void lblAge_Click(object sender, EventArgs e)
        {

        }

        private void lblJoinDate_Click(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void lblid_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void lblEndDate_Click(object sender, EventArgs e)
        {

        }

        private void lblTraineeClass_Click(object sender, EventArgs e)
        {

        }

        private void lblSubscriptionFee_Click(object sender, EventArgs e)
        {

        }

        private void btnTraineeSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTraineeAge.Text) || (string.IsNullOrEmpty(txtTraineeClass.Text)) ||
                (string.IsNullOrEmpty(txtTraineeID.Text)) || (string.IsNullOrEmpty(txtTraineeName.Text)) ||
                (string.IsNullOrEmpty(txtTraineePhone.Text)) || (string.IsNullOrEmpty(txtTraineeSubscriptionFee.Text))
                )
            {

                lblErrTrinee.Text = " You Must Enter All Information ";
                lblErrTrinee.Visible = true;

            }
        }
    }
}
