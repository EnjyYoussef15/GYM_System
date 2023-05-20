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
    public partial class SearchTraineeForm : Form
    {
        public SearchTraineeForm()
        {
            InitializeComponent();
        }

        private void btnSearchReset_Click(object sender, EventArgs e)
        {
            txtSearch_Search.Text = "";
        }

        private void btnSearchBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }
    }
}
