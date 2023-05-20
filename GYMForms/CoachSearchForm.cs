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
    public partial class CoachSearchForm : Form
    {
        public CoachSearchForm()
        {
            InitializeComponent();
            grdCoachSearch.AutoGenerateColumns = true;
            grdCoachSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CoachSearchForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCoachSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnCoachRefresh_Click(object sender, EventArgs e)
        {
            txtCoachSearch.Text = "";
        }

        private void btnCoachBack_Click(object sender, EventArgs e)
        {
            Hide();

        }
    }
}
