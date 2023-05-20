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
    public partial class WorkerSearchForm : Form
    {
        public WorkerSearchForm()
        {
            InitializeComponent();
            grdWorkerSearch.AutoGenerateColumns = true;
            grdWorkerSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void WorkerSearchForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCoachRefresh_Click(object sender, EventArgs e)
        {
            txtWorkerSearch.Text = "";
        }

        private void btnWorkerBack_Click(object sender, EventArgs e)
        {
            Hide();

        }
    }
}
