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
    public partial class WorkerForm : Form
    {
        public WorkerForm()
        {
            InitializeComponent();
            grdWorkerUpdate.AutoGenerateColumns = true;
            grdWorkerUpdate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnWorkerBack_Click(object sender, EventArgs e)
        {
            Hide();

        }

        private void btnWorkerDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{txtWorkerName.Text}, Data is Deleted");
        }

        private void btnWorkerUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{txtWorkerName.Text}, Data is Updated");
        }
    }
}
