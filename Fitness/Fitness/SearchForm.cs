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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void btnSearchFromBack_Click(object sender, EventArgs e)
        {
            this.Close();
            TraineeForm traineeForm = new TraineeForm();
            traineeForm.ShowDialog();
        }

        private void btnSearchFormReset_Click(object sender, EventArgs e)
        {
            txtSearch_Search.Text = "";
        }

        private void btnSearch_Search_Click(object sender, EventArgs e)
        {

        }
    }
}
