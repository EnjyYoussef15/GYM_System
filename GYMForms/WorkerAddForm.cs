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
    public partial class WorkerAddForm : Form
    {
        public WorkerAddForm()
        {
            InitializeComponent();
        }

        private void btnWorkerReset_Click(object sender, EventArgs e)
        {
            txtWorkerID.Text = string.Empty;
            txtWorkerJob.Text = string.Empty;
            txtWorkerName.Text = string.Empty;
            txtWorkerSalary.Text = string.Empty;
            radFemale.Checked = false;
            radMale.Checked = false;
        }

        private void btnWorkerBack_Click(object sender, EventArgs e)
        {
            Hide();

        }

        private void btnWorkerAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtWorkerID.Text)
                || (string.IsNullOrEmpty(txtWorkerJob.Text))
                || (string.IsNullOrEmpty(txtWorkerName.Text))
                || (string.IsNullOrEmpty(txtWorkerSalary.Text)))
            {

                lblErrWorker.Text = " You Must Enter All Information ";
                lblErrWorker.Visible = true;

            }
            else
            {
                txtWorkerID.Text = string.Empty;
                txtWorkerJob.Text = string.Empty;
                txtWorkerName.Text = string.Empty;
                txtWorkerSalary.Text = string.Empty;
                radFemale.Checked = false;
                radMale.Checked = false;
                MessageBox.Show("Done");
            }

        }
    }
}
